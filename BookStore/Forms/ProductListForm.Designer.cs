namespace BookStore.Forms
{
    partial class ProductListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this._userLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.Panel();
            this._sortBox = new System.Windows.Forms.ComboBox();
            this.sortLabel = new System.Windows.Forms.Label();
            this._supplierFilter = new System.Windows.Forms.ComboBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this._logoutButton = new System.Windows.Forms.Button();
            this._ordersButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._grid = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();
            
            this.topPanel.Controls.Add(this._userLabel);
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1100, 50);
            this.topPanel.TabIndex = 0;
           
            this._userLabel.AutoSize = true;
            this._userLabel.Location = new System.Drawing.Point(850, 18);
            this._userLabel.Name = "_userLabel";
            this._userLabel.Size = new System.Drawing.Size(0, 15);
            this._userLabel.TabIndex = 1;
            
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(130, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Каталог книг";
           
            this.filterPanel.Controls.Add(this._sortBox);
            this.filterPanel.Controls.Add(this.sortLabel);
            this.filterPanel.Controls.Add(this._supplierFilter);
            this.filterPanel.Controls.Add(this.supplierLabel);
            this.filterPanel.Controls.Add(this._searchBox);
            this.filterPanel.Controls.Add(this.searchLabel);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 50);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1100, 55);
            this.filterPanel.TabIndex = 1;
           
            this._sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sortBox.Items.AddRange(new object[] { "Без сортировки", "Кол-во: по возрастанию", "Кол-во: по убыванию" });
            this._sortBox.Location = new System.Drawing.Point(750, 18);
            this._sortBox.Name = "_sortBox";
            this._sortBox.Size = new System.Drawing.Size(200, 23);
            this._sortBox.TabIndex = 5;
            this._sortBox.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(670, 21);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(73, 15);
            this.sortLabel.TabIndex = 4;
            this.sortLabel.Text = "Сортировка:";
            
            this._supplierFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._supplierFilter.Location = new System.Drawing.Point(450, 18);
            this._supplierFilter.Name = "_supplierFilter";
            this._supplierFilter.Size = new System.Drawing.Size(200, 23);
            this._supplierFilter.TabIndex = 3;
            this._supplierFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(370, 21);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(73, 15);
            this.supplierLabel.TabIndex = 2;
            this.supplierLabel.Text = "Поставщик:";
            
            this._searchBox.Location = new System.Drawing.Point(90, 18);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(260, 23);
            this._searchBox.TabIndex = 1;
            this._searchBox.TextChanged += new System.EventHandler(this.Filter_Changed);
            
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(30, 21);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(46, 15);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Поиск:";
           
            this.bottomPanel.Controls.Add(this._logoutButton);
            this.bottomPanel.Controls.Add(this._ordersButton);
            this.bottomPanel.Controls.Add(this._deleteButton);
            this.bottomPanel.Controls.Add(this._addButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 600);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1100, 60);
            this.bottomPanel.TabIndex = 2;
           
            this._logoutButton.Location = new System.Drawing.Point(950, 15);
            this._logoutButton.Name = "_logoutButton";
            this._logoutButton.Size = new System.Drawing.Size(130, 30);
            this._logoutButton.TabIndex = 3;
            this._logoutButton.Text = "Выход";
            this._logoutButton.UseVisualStyleBackColor = true;
            this._logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
             
            this._ordersButton.Location = new System.Drawing.Point(370, 15);
            this._ordersButton.Name = "_ordersButton";
            this._ordersButton.Size = new System.Drawing.Size(160, 30);
            this._ordersButton.TabIndex = 2;
            this._ordersButton.Text = "Заказы";
            this._ordersButton.UseVisualStyleBackColor = true;
            this._ordersButton.Visible = false;
            this._ordersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            
            this._deleteButton.Location = new System.Drawing.Point(190, 15);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(160, 30);
            this._deleteButton.TabIndex = 1;
            this._deleteButton.Text = "Удалить книгу";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Visible = false;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            
            this._addButton.Location = new System.Drawing.Point(20, 15);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(160, 30);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Добавить книгу";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Visible = false;
            this._addButton.Click += new System.EventHandler(this.AddButton_Click);
            
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.Location = new System.Drawing.Point(0, 105);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(1100, 495);
            this._grid.TabIndex = 3;
            this._grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this._grid);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "ProductListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЧитайГород - Каталог книг";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label _userLabel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox _searchBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox _supplierFilter;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.ComboBox _sortBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _ordersButton;
        private System.Windows.Forms.Button _logoutButton;
        private System.Windows.Forms.DataGridView _grid;
    }
}