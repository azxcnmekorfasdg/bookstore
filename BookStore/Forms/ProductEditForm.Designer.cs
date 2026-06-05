namespace BookStore.Forms
{
    partial class ProductEditForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this._idBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this._nameBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this._descBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this._categoryBox = new System.Windows.Forms.ComboBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this._manufacturerBox = new System.Windows.Forms.ComboBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this._supplierBox = new System.Windows.Forms.ComboBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this._unitBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this._priceBox = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this._quantityBox = new System.Windows.Forms.NumericUpDown();
            this.discountLabel = new System.Windows.Forms.Label();
            this._discountBox = new System.Windows.Forms.NumericUpDown();
            this.articleLabel = new System.Windows.Forms.Label();
            this._articleBox = new System.Windows.Forms.TextBox();
            this._imageBox = new System.Windows.Forms.PictureBox();
            this._selectImageButton = new System.Windows.Forms.Button();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._quantityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._discountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageBox)).BeginInit();
            this.SuspendLayout();
            
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(30, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
           
            this._idBox.Location = new System.Drawing.Point(200, 22);
            this._idBox.Name = "_idBox";
            this._idBox.ReadOnly = true;
            this._idBox.Size = new System.Drawing.Size(150, 23);
            this._idBox.TabIndex = 1;
            
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(30, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Название:";
            
            this._nameBox.Location = new System.Drawing.Point(200, 62);
            this._nameBox.Name = "_nameBox";
            this._nameBox.Size = new System.Drawing.Size(450, 23);
            this._nameBox.TabIndex = 3;
           
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(30, 105);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(72, 15);
            this.descLabel.TabIndex = 4;
            this.descLabel.Text = "Описание:";
            
            this._descBox.Location = new System.Drawing.Point(200, 102);
            this._descBox.Multiline = true;
            this._descBox.Name = "_descBox";
            this._descBox.Size = new System.Drawing.Size(450, 70);
            this._descBox.TabIndex = 5;
           
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(30, 185);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(64, 15);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Категория:";
            
            this._categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._categoryBox.Location = new System.Drawing.Point(200, 182);
            this._categoryBox.Name = "_categoryBox";
            this._categoryBox.Size = new System.Drawing.Size(280, 23);
            this._categoryBox.TabIndex = 7;
            
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(30, 225);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(81, 15);
            this.manufacturerLabel.TabIndex = 8;
            this.manufacturerLabel.Text = "Издательство:";
           
            this._manufacturerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._manufacturerBox.Location = new System.Drawing.Point(200, 222);
            this._manufacturerBox.Name = "_manufacturerBox";
            this._manufacturerBox.Size = new System.Drawing.Size(280, 23);
            this._manufacturerBox.TabIndex = 9;
            
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(30, 265);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(73, 15);
            this.supplierLabel.TabIndex = 10;
            this.supplierLabel.Text = "Поставщик:";
            
            this._supplierBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._supplierBox.Location = new System.Drawing.Point(200, 262);
            this._supplierBox.Name = "_supplierBox";
            this._supplierBox.Size = new System.Drawing.Size(280, 23);
            this._supplierBox.TabIndex = 11;
           
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(30, 305);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(101, 15);
            this.unitLabel.TabIndex = 12;
            this.unitLabel.Text = "Единица измерения:";
            
            this._unitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._unitBox.Location = new System.Drawing.Point(200, 302);
            this._unitBox.Name = "_unitBox";
            this._unitBox.Size = new System.Drawing.Size(150, 23);
            this._unitBox.TabIndex = 13;
            
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(30, 345);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(39, 15);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Цена:";
           
            this._priceBox.DecimalPlaces = 2;
            this._priceBox.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this._priceBox.Location = new System.Drawing.Point(200, 342);
            this._priceBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this._priceBox.Name = "_priceBox";
            this._priceBox.Size = new System.Drawing.Size(150, 23);
            this._priceBox.TabIndex = 15;
            
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(30, 385);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 15);
            this.quantityLabel.TabIndex = 16;
            this.quantityLabel.Text = "Количество:";
            
            this._quantityBox.Location = new System.Drawing.Point(200, 382);
            this._quantityBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this._quantityBox.Name = "_quantityBox";
            this._quantityBox.Size = new System.Drawing.Size(150, 23);
            this._quantityBox.TabIndex = 17;
            
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(30, 425);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(70, 15);
            this.discountLabel.TabIndex = 18;
            this.discountLabel.Text = "Скидка, %:";
            
            this._discountBox.Location = new System.Drawing.Point(200, 422);
            this._discountBox.Name = "_discountBox";
            this._discountBox.Size = new System.Drawing.Size(150, 23);
            this._discountBox.TabIndex = 19;
            
            this.articleLabel.AutoSize = true;
            this.articleLabel.Location = new System.Drawing.Point(30, 465);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(56, 15);
            this.articleLabel.TabIndex = 20;
            this.articleLabel.Text = "Артикул:";
            
            this._articleBox.Location = new System.Drawing.Point(200, 462);
            this._articleBox.Name = "_articleBox";
            this._articleBox.Size = new System.Drawing.Size(150, 23);
            this._articleBox.TabIndex = 21;
            
            this._imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imageBox.Location = new System.Drawing.Point(520, 180);
            this._imageBox.Name = "_imageBox";
            this._imageBox.Size = new System.Drawing.Size(180, 150);
            this._imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imageBox.TabIndex = 22;
            this._imageBox.TabStop = false;
            
            this._selectImageButton.Location = new System.Drawing.Point(520, 340);
            this._selectImageButton.Name = "_selectImageButton";
            this._selectImageButton.Size = new System.Drawing.Size(180, 35);
            this._selectImageButton.TabIndex = 23;
            this._selectImageButton.Text = "Выбрать фото...";
            this._selectImageButton.UseVisualStyleBackColor = true;
            this._selectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
           
            this._saveButton.Location = new System.Drawing.Point(520, 540);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(180, 40);
            this._saveButton.TabIndex = 24;
            this._saveButton.Text = "Сохранить";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(290, 540);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(180, 40);
            this._cancelButton.TabIndex = 25;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(734, 610);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._selectImageButton);
            this.Controls.Add(this._imageBox);
            this.Controls.Add(this._articleBox);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this._discountBox);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this._quantityBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this._priceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this._unitBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this._supplierBox);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this._manufacturerBox);
            this.Controls.Add(this.manufacturerLabel);
            this.Controls.Add(this._categoryBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this._descBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this._nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this._idBox);
            this.Controls.Add(this.idLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Книга";
            ((System.ComponentModel.ISupportInitialize)(this._priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._quantityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._discountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox _idBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox _nameBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox _descBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox _categoryBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.ComboBox _manufacturerBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox _supplierBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ComboBox _unitBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown _priceBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown _quantityBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.NumericUpDown _discountBox;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.TextBox _articleBox;
        private System.Windows.Forms.PictureBox _imageBox;
        private System.Windows.Forms.Button _selectImageButton;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}