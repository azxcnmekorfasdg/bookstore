using BookStore.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BookStore.Forms
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
            ApplyDesign();

            _addButton.Visible = AppSession.IsAdmin;
            _editButton.Visible = AppSession.IsAdmin;
            _deleteButton.Visible = AppSession.IsAdmin;

            LoadOrders();
        }

        private void ApplyDesign()
        {
            this.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.White;
            topPanel.BackColor = Color.FromArgb(171, 207, 206);
            bottomPanel.BackColor = Color.FromArgb(171, 207, 206);
            _addButton.BackColor = Color.FromArgb(84, 111, 148);
            _editButton.BackColor = Color.FromArgb(84, 111, 148);
            _deleteButton.BackColor = Color.FromArgb(84, 111, 148);
            _closeButton.BackColor = Color.FromArgb(84, 111, 148);
            _addButton.ForeColor = Color.White;
            _editButton.ForeColor = Color.White;
            _deleteButton.ForeColor = Color.White;
            _closeButton.ForeColor = Color.White;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenEdit(0);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_grid.CurrentRow != null)
                OpenEdit((int)_grid.CurrentRow.Cells["OrderId"].Value);
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                OpenEdit((int)_grid.Rows[e.RowIndex].Cells["OrderId"].Value);
        }

        private void LoadOrders()
        {
            try
            {
                string sql = @"
                    SELECT o.OrderId, o.OrderCode, o.OrderDate, o.DeliveryDate, o.PickupCode,
                           s.StatusName, p.Address AS PickupAddress, u.FullName AS ClientName
                    FROM Orders o
                    INNER JOIN OrderStatuses s ON o.StatusId = s.StatusId
                    INNER JOIN PickupPoints p ON o.PickupPointId = p.PickupPointId
                    LEFT JOIN Users u ON o.UserId = u.UserId
                    ORDER BY o.OrderId DESC;";

                DataTable table = DatabaseHelper.ExecuteQuery(sql);
                _grid.DataSource = table;

                if (_grid.Columns.Contains("OrderId"))
                    _grid.Columns["OrderId"].HeaderText = "ID";
                if (_grid.Columns.Contains("OrderCode"))
                    _grid.Columns["OrderCode"].HeaderText = "Артикул заказа";
                if (_grid.Columns.Contains("StatusName"))
                    _grid.Columns["StatusName"].HeaderText = "Статус";
                if (_grid.Columns.Contains("PickupAddress"))
                    _grid.Columns["PickupAddress"].HeaderText = "Пункт выдачи";
                if (_grid.Columns.Contains("OrderDate"))
                    _grid.Columns["OrderDate"].HeaderText = "Дата заказа";
                if (_grid.Columns.Contains("DeliveryDate"))
                    _grid.Columns["DeliveryDate"].HeaderText = "Дата выдачи";
                if (_grid.Columns.Contains("PickupCode"))
                    _grid.Columns["PickupCode"].HeaderText = "Код получения";
                if (_grid.Columns.Contains("ClientName"))
                    _grid.Columns["ClientName"].HeaderText = "Клиент";

                if (_grid.Columns.Contains("OrderId"))
                    _grid.Columns["OrderId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заказов: " + ex.Message);
            }
        }

        private void OpenEdit(int orderId)
        {
            if (!AppSession.IsAdmin)
            {
                MessageBox.Show("Редактирование заказов доступно только администратору.");
                return;
            }
            OrderEditForm form = new OrderEditForm(orderId);
            if (form.ShowDialog(this) == DialogResult.OK)
                LoadOrders();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_grid.CurrentRow == null)
            {
                MessageBox.Show("Выберите заказ.");
                return;
            }

            int id = (int)_grid.CurrentRow.Cells["OrderId"].Value;
            string code = _grid.CurrentRow.Cells["OrderCode"].Value.ToString();

            if (MessageBox.Show("Удалить заказ " + code + "?", "Подтверждение",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                DatabaseHelper.ExecuteNonQuery(
                    "DELETE FROM Orders WHERE OrderId = @id;",
                    new SqlParameter("@id", id));
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }
    }
}