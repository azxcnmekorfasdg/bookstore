using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class OrderEditForm : Form
    {
        private int _orderId;
        private bool _isNew;

        public OrderEditForm(int orderId)
        {
            _orderId = orderId;
            _isNew = (orderId == 0);
            InitializeComponent();
            ApplyDesign();

            if (_isNew)
                this.Text = "Добавление заказа";
            else
                this.Text = "Редактирование заказа";

            FillReferences();
            FillFields();
        }

        private void ApplyDesign()
        {
            this.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.White;
            _saveButton.BackColor = Color.FromArgb(84, 111, 148);
            _cancelButton.BackColor = Color.FromArgb(84, 111, 148);
            _saveButton.ForeColor = Color.White;
            _cancelButton.ForeColor = Color.White;
        }

        private void HasDelivery_Changed(object sender, EventArgs e)
        {
            _deliveryDatePicker.Enabled = _hasDeliveryBox.Checked;
        }

        private void FillReferences()
        {
            try
            {
                DataTable statuses = DatabaseHelper.ExecuteQuery("SELECT StatusId AS Id, StatusName AS Name FROM OrderStatuses ORDER BY StatusId;");
                _statusBox.DataSource = statuses;
                _statusBox.DisplayMember = "Name";
                _statusBox.ValueMember = "Id";

                DataTable points = DatabaseHelper.ExecuteQuery("SELECT PickupPointId AS Id, Address AS Name FROM PickupPoints ORDER BY Address;");
                _pickupBox.DataSource = points;
                _pickupBox.DisplayMember = "Name";
                _pickupBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки справочников: " + ex.Message);
            }
        }

        private void FillFields()
        {
            _orderDatePicker.Value = DateTime.Today;
            _deliveryDatePicker.Value = DateTime.Today.AddDays(5);

            if (_isNew)
            {
                object next = DatabaseHelper.ExecuteScalar("SELECT ISNULL(MAX(CAST(SUBSTRING(OrderCode, 5, LEN(OrderCode)) AS INT)), 0) + 1 FROM Orders WHERE OrderCode LIKE 'ORD-%';");
                _codeBox.Text = "ORD-" + Convert.ToInt32(next).ToString("D5");
                return;
            }

            try
            {
                DataTable t = DatabaseHelper.ExecuteQuery(
                    "SELECT OrderCode, StatusId, PickupPointId, OrderDate, DeliveryDate, PickupCode FROM Orders WHERE OrderId = @id;",
                    new SqlParameter("@id", _orderId));

                if (t.Rows.Count == 0)
                    return;

                DataRow r = t.Rows[0];

                _codeBox.Text = r["OrderCode"].ToString();
                _statusBox.SelectedValue = (int)r["StatusId"];
                _pickupBox.SelectedValue = (int)r["PickupPointId"];
                _orderDatePicker.Value = (DateTime)r["OrderDate"];
                _pickupCodeBox.Text = r["PickupCode"] == DBNull.Value ? "" : r["PickupCode"].ToString();

                if (r["DeliveryDate"] != DBNull.Value)
                {
                    _hasDeliveryBox.Checked = true;
                    _deliveryDatePicker.Value = (DateTime)r["DeliveryDate"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заказа: " + ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_codeBox.Text.Trim() == "")
            {
                MessageBox.Show("Укажите артикул заказа.");
                return;
            }

            if (_statusBox.SelectedValue == null || _pickupBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите статус и пункт выдачи.");
                return;
            }

            object deliveryDate;
            if (_hasDeliveryBox.Checked)
                deliveryDate = _deliveryDatePicker.Value.Date;
            else
                deliveryDate = DBNull.Value;

            object pickupCode = string.IsNullOrEmpty(_pickupCodeBox.Text) ? DBNull.Value : (object)_pickupCodeBox.Text.Trim();

            try
            {
                if (_isNew)
                {
                    object uid;
                    if (AppSession.CurrentUser != null)
                        uid = AppSession.CurrentUser.UserId;
                    else
                        uid = DBNull.Value;

                    DatabaseHelper.ExecuteNonQuery(
                        @"INSERT INTO Orders (OrderCode, StatusId, PickupPointId, OrderDate, DeliveryDate, UserId, PickupCode) 
                          VALUES (@code, @status, @pickup, @odate, @ddate, @uid, @pickupCode);",
                        new SqlParameter("@code", _codeBox.Text.Trim()),
                        new SqlParameter("@status", (int)_statusBox.SelectedValue),
                        new SqlParameter("@pickup", (int)_pickupBox.SelectedValue),
                        new SqlParameter("@odate", _orderDatePicker.Value.Date),
                        new SqlParameter("@ddate", deliveryDate),
                        new SqlParameter("@uid", uid),
                        new SqlParameter("@pickupCode", pickupCode));
                }
                else
                {
                    DatabaseHelper.ExecuteNonQuery(
                        @"UPDATE Orders SET 
                            OrderCode = @code, 
                            StatusId = @status, 
                            PickupPointId = @pickup, 
                            OrderDate = @odate, 
                            DeliveryDate = @ddate,
                            PickupCode = @pickupCode
                          WHERE OrderId = @id;",
                        new SqlParameter("@id", _orderId),
                        new SqlParameter("@code", _codeBox.Text.Trim()),
                        new SqlParameter("@status", (int)_statusBox.SelectedValue),
                        new SqlParameter("@pickup", (int)_pickupBox.SelectedValue),
                        new SqlParameter("@odate", _orderDatePicker.Value.Date),
                        new SqlParameter("@ddate", deliveryDate),
                        new SqlParameter("@pickupCode", pickupCode));
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
    }
}