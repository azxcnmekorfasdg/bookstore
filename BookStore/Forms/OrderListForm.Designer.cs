namespace BookStore.Forms
{
    partial class OrderListForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this._closeButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._editButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._grid = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this.SuspendLayout();
           
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(950, 45);
            this.topPanel.TabIndex = 0;
           
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(125, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Список заказов";
            
            this.bottomPanel.Controls.Add(this._closeButton);
            this.bottomPanel.Controls.Add(this._deleteButton);
            this.bottomPanel.Controls.Add(this._editButton);
            this.bottomPanel.Controls.Add(this._addButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 500);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(950, 55);
            this.bottomPanel.TabIndex = 1;
            
            this._closeButton.Location = new System.Drawing.Point(800, 12);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(130, 30);
            this._closeButton.TabIndex = 3;
            this._closeButton.Text = "Назад";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
           
            this._deleteButton.Location = new System.Drawing.Point(370, 12);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(160, 30);
            this._deleteButton.TabIndex = 2;
            this._deleteButton.Text = "Удалить";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            
            this._editButton.Location = new System.Drawing.Point(190, 12);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(160, 30);
            this._editButton.TabIndex = 1;
            this._editButton.Text = "Редактировать";
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Click += new System.EventHandler(this.EditButton_Click);
            
            this._addButton.Location = new System.Drawing.Point(20, 12);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(160, 30);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "Добавить заказ";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButton_Click);
            
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.Location = new System.Drawing.Point(0, 45);
            this._grid.MultiSelect = false;
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowHeadersVisible = false;
            this._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grid.Size = new System.Drawing.Size(950, 455);
            this._grid.TabIndex = 2;
            this._grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            
            this.ClientSize = new System.Drawing.Size(950, 555);
            this.Controls.Add(this._grid);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "OrderListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказы - ЧитайГород";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.DataGridView _grid;
    }
}