using BookStore.Models;
using BookStore.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class ProductListForm : Form
    {
        private List<Product> _allProducts = new List<Product>();
        private static ProductEditForm _editForm;

        public ProductListForm()
        {
            InitializeComponent();
            ApplyRoleVisibility();
            LoadProducts();
        }

        private void ApplyRoleVisibility()
        {
            this.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);

            this.BackColor = Color.White;
            filterPanel.BackColor = Color.FromArgb(171, 207, 206);
            bottomPanel.BackColor = Color.FromArgb(171, 207, 206);

            if (AppSession.IsGuest)
            {
                _userLabel.Text = "Гость";
                HideFilters();
            }
            else if (AppSession.IsClient)
            {
                _userLabel.Text = AppSession.CurrentUser.FullName + " (Клиент)";
                HideFilters();
            }
            else if (AppSession.IsManager)
            {
                _userLabel.Text = AppSession.CurrentUser.FullName + " (Менеджер)";
                ShowFilters();
                _ordersButton.Visible = true;
            }
            else if (AppSession.IsAdmin)
            {
                _userLabel.Text = AppSession.CurrentUser.FullName + " (Администратор)";
                ShowFilters();
                _ordersButton.Visible = true;
                _addButton.Visible = true;
                _deleteButton.Visible = true;
            }
        }

        private void HideFilters()
        {
            _searchBox.Visible = false;
            _supplierFilter.Visible = false;
            _sortBox.Visible = false;
            searchLabel.Visible = false;
            supplierLabel.Visible = false;
            sortLabel.Visible = false;
        }

        private void ShowFilters()
        {
            _searchBox.Visible = true;
            _supplierFilter.Visible = true;
            _sortBox.Visible = true;
            searchLabel.Visible = true;
            supplierLabel.Visible = true;
            sortLabel.Visible = true;
        }

        private void LoadProducts()
        {
            try
            {
                string sql = @"
                    SELECT p.ProductId, p.ProductName, p.Description, p.Price, p.Quantity, p.Discount, p.ImagePath, p.Article,
                           c.CategoryId, c.CategoryName,
                           m.ManufacturerId, m.ManufacturerName,
                           s.SupplierId, s.SupplierName,
                           u.UnitId, u.UnitName
                    FROM Products p
                    INNER JOIN Categories c ON p.CategoryId = c.CategoryId
                    INNER JOIN Manufacturers m ON p.ManufacturerId = m.ManufacturerId
                    INNER JOIN Suppliers s ON p.SupplierId = s.SupplierId
                    INNER JOIN Units u ON p.UnitId = u.UnitId
                    ORDER BY p.ProductId;";

                DataTable table = DatabaseHelper.ExecuteQuery(sql);
                _allProducts.Clear();

                foreach (DataRow r in table.Rows)
                {
                    Product p = new Product
                    {
                        ProductId = (int)r["ProductId"],
                        ProductName = r["ProductName"].ToString(),
                        Description = r["Description"] == DBNull.Value ? "" : r["Description"].ToString(),
                        CategoryId = (int)r["CategoryId"],
                        CategoryName = r["CategoryName"].ToString(),
                        ManufacturerId = (int)r["ManufacturerId"],
                        ManufacturerName = r["ManufacturerName"].ToString(),
                        SupplierId = (int)r["SupplierId"],
                        SupplierName = r["SupplierName"].ToString(),
                        UnitId = (int)r["UnitId"],
                        UnitName = r["UnitName"].ToString(),
                        Price = (decimal)r["Price"],
                        Quantity = (int)r["Quantity"],
                        Discount = (int)r["Discount"],
                        ImagePath = r["ImagePath"] == DBNull.Value ? null : r["ImagePath"].ToString(),
                        Article = r["Article"] == DBNull.Value ? "" : r["Article"].ToString()
                    };
                    _allProducts.Add(p);
                }

                ReloadSupplierFilter();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки книг: " + ex.Message);
            }
        }

        private void ReloadSupplierFilter()
        {
            _supplierFilter.Items.Clear();
            _supplierFilter.Items.Add("Все поставщики");
            List<string> added = new List<string>();
            foreach (Product p in _allProducts)
            {
                if (!added.Contains(p.SupplierName))
                {
                    added.Add(p.SupplierName);
                    _supplierFilter.Items.Add(p.SupplierName);
                }
            }
            _supplierFilter.SelectedIndex = 0;
        }

        private void RefreshGrid()
        {
            List<Product> data = new List<Product>();

            if (AppSession.IsManager || AppSession.IsAdmin)
            {
                string query = _searchBox.Text.Trim().ToLower();
                string supplier = _supplierFilter.SelectedItem?.ToString() ?? "Все поставщики";

                foreach (Product p in _allProducts)
                {
                    if (query != "")
                    {
                        string searchText = (p.ProductName + " " + p.Description + " " +
                                           p.CategoryName + " " + p.ManufacturerName + " " +
                                           p.SupplierName + " " + p.UnitName).ToLower();
                        if (!searchText.Contains(query))
                            continue;
                    }

                    if (supplier != "Все поставщики" && p.SupplierName != supplier)
                        continue;

                    data.Add(p);
                }

                if (_sortBox.SelectedIndex == 1)
                    data = data.OrderBy(x => x.Quantity).ToList();
                else if (_sortBox.SelectedIndex == 2)
                    data = data.OrderByDescending(x => x.Quantity).ToList();
            }
            else
            {
                data = new List<Product>(_allProducts);
            }

            BindGrid(data);
        }

        private void BindGrid(List<Product> list)
        {
            _grid.Rows.Clear();
            _grid.Columns.Clear();

            _grid.Columns.Add("Id", "ID");
            _grid.Columns.Add("Article", "Артикул");
            _grid.Columns.Add("Name", "Наименование");
            _grid.Columns.Add("Category", "Категория");
            _grid.Columns.Add("Manufacturer", "Издательство");
            _grid.Columns.Add("Supplier", "Поставщик");
            _grid.Columns.Add("Qty", "Кол-во");
            _grid.Columns.Add("Price", "Цена");
            _grid.Columns.Add("Discount", "Скидка, %");

            _grid.Columns["Id"].Width = 50;
            _grid.Columns["Article"].Width = 80;
            _grid.Columns["Name"].Width = 200;
            _grid.Columns["Price"].Width = 100;

            foreach (Product p in list)
            {
                string priceCell = p.Discount > 0
                    ? p.Price.ToString("N2") + " → " + p.FinalPrice.ToString("N2")
                    : p.Price.ToString("N2");

                int rowIndex = _grid.Rows.Add(
                    p.ProductId, p.Article, p.ProductName, p.CategoryName,
                    p.ManufacturerName, p.SupplierName, p.Quantity, priceCell, p.Discount);

                _grid.Rows[rowIndex].Tag = p;

                if (p.Discount > 25)
                {
                    _grid.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(35, 225, 239);
                }
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenEditForm(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_grid.CurrentRow == null)
            {
                MessageBox.Show("Выберите книгу для удаления.");
                return;
            }

            Product product = (Product)_grid.CurrentRow.Tag;
            if (product == null) return;

            if (MessageBox.Show("Удалить книгу \"" + product.ProductName + "\"?", "Подтверждение",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                int count = (int)DatabaseHelper.ExecuteScalar(
                    "SELECT COUNT(*) FROM OrderItems WHERE ProductId = @id;",
                    new SqlParameter("@id", product.ProductId));

                if (count > 0)
                {
                    MessageBox.Show("Эта книга присутствует в заказах и не может быть удалена.");
                    return;
                }

                DatabaseHelper.ExecuteNonQuery(
                    "DELETE FROM Products WHERE ProductId = @id;",
                    new SqlParameter("@id", product.ProductId));

                if (!string.IsNullOrEmpty(product.ImagePath) && File.Exists(product.ImagePath))
                {
                    try { File.Delete(product.ImagePath); } catch { }
                }

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!AppSession.IsAdmin)
            {
                MessageBox.Show("Редактирование доступно только администратору.");
                return;
            }
            Product product = (Product)_grid.Rows[e.RowIndex].Tag;
            if (product != null)
                OpenEditForm(product);
        }

        private void OpenEditForm(Product product)
        {
            if (_editForm != null && !_editForm.IsDisposed)
            {
                MessageBox.Show("Окно редактирования уже открыто.");
                _editForm.Activate();
                return;
            }

            _editForm = new ProductEditForm(product);
            _editForm.FormClosed += (s, args) => { _editForm = null; LoadProducts(); };
            _editForm.ShowDialog(this);
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrderListForm form = new OrderListForm();
            form.ShowDialog(this);
        }
    }
}