namespace BookStore.Forms
{
    partial class OrderEditForm
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
            this.codeLabel = new System.Windows.Forms.Label();
            this._codeBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this._statusBox = new System.Windows.Forms.ComboBox();
            this.pickupLabel = new System.Windows.Forms.Label();
            this._pickupBox = new System.Windows.Forms.ComboBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this._orderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this._hasDeliveryBox = new System.Windows.Forms.CheckBox();
            this._deliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pickupCodeLabel = new System.Windows.Forms.Label();
            this._pickupCodeBox = new System.Windows.Forms.TextBox();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(30, 30);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(97, 15);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Артикул заказа:";
            
            this._codeBox.Location = new System.Drawing.Point(200, 27);
            this._codeBox.Name = "_codeBox";
            this._codeBox.Size = new System.Drawing.Size(250, 23);
            this._codeBox.TabIndex = 1;
           
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(30, 70);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 15);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Статус:";
           
            this._statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusBox.Location = new System.Drawing.Point(200, 67);
            this._statusBox.Name = "_statusBox";
            this._statusBox.Size = new System.Drawing.Size(250, 23);
            this._statusBox.TabIndex = 3;
            
            this.pickupLabel.AutoSize = true;
            this.pickupLabel.Location = new System.Drawing.Point(30, 110);
            this.pickupLabel.Name = "pickupLabel";
            this.pickupLabel.Size = new System.Drawing.Size(87, 15);
            this.pickupLabel.TabIndex = 4;
            this.pickupLabel.Text = "Пункт выдачи:";
          
            this._pickupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._pickupBox.Location = new System.Drawing.Point(200, 107);
            this._pickupBox.Name = "_pickupBox";
            this._pickupBox.Size = new System.Drawing.Size(300, 23);
            this._pickupBox.TabIndex = 5;
             
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(30, 150);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(79, 15);
            this.orderDateLabel.TabIndex = 6;
            this.orderDateLabel.Text = "Дата заказа:";
            
            this._orderDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._orderDatePicker.Location = new System.Drawing.Point(200, 147);
            this._orderDatePicker.Name = "_orderDatePicker";
            this._orderDatePicker.Size = new System.Drawing.Size(250, 23);
            this._orderDatePicker.TabIndex = 7;
            
            this.deliveryDateLabel.AutoSize = true;
            this.deliveryDateLabel.Location = new System.Drawing.Point(30, 190);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(77, 15);
            this.deliveryDateLabel.TabIndex = 8;
            this.deliveryDateLabel.Text = "Дата выдачи:";
            
            this._hasDeliveryBox.AutoSize = true;
            this._hasDeliveryBox.Location = new System.Drawing.Point(200, 189);
            this._hasDeliveryBox.Name = "_hasDeliveryBox";
            this._hasDeliveryBox.Size = new System.Drawing.Size(72, 19);
            this._hasDeliveryBox.TabIndex = 9;
            this._hasDeliveryBox.Text = "Указать";
            this._hasDeliveryBox.UseVisualStyleBackColor = true;
            this._hasDeliveryBox.CheckedChanged += new System.EventHandler(this.HasDelivery_Changed);
            
            this._deliveryDatePicker.Enabled = false;
            this._deliveryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._deliveryDatePicker.Location = new System.Drawing.Point(295, 187);
            this._deliveryDatePicker.Name = "_deliveryDatePicker";
            this._deliveryDatePicker.Size = new System.Drawing.Size(155, 23);
            this._deliveryDatePicker.TabIndex = 10;
           
            this.pickupCodeLabel.AutoSize = true;
            this.pickupCodeLabel.Location = new System.Drawing.Point(30, 230);
            this.pickupCodeLabel.Name = "pickupCodeLabel";
            this.pickupCodeLabel.Size = new System.Drawing.Size(92, 15);
            this.pickupCodeLabel.TabIndex = 11;
            this.pickupCodeLabel.Text = "Код получения:";
            
            this._pickupCodeBox.Location = new System.Drawing.Point(200, 227);
            this._pickupCodeBox.Name = "_pickupCodeBox";
            this._pickupCodeBox.Size = new System.Drawing.Size(150, 23);
            this._pickupCodeBox.TabIndex = 12;
            
            this._saveButton.Location = new System.Drawing.Point(310, 320);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(180, 40);
            this._saveButton.TabIndex = 13;
            this._saveButton.Text = "Сохранить";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(90, 320);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(180, 40);
            this._cancelButton.TabIndex = 14;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
             
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(554, 410);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._pickupCodeBox);
            this.Controls.Add(this.pickupCodeLabel);
            this.Controls.Add(this._deliveryDatePicker);
            this.Controls.Add(this._hasDeliveryBox);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this._orderDatePicker);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this._pickupBox);
            this.Controls.Add(this.pickupLabel);
            this.Controls.Add(this._statusBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this._codeBox);
            this.Controls.Add(this.codeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox _codeBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox _statusBox;
        private System.Windows.Forms.Label pickupLabel;
        private System.Windows.Forms.ComboBox _pickupBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.DateTimePicker _orderDatePicker;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.CheckBox _hasDeliveryBox;
        private System.Windows.Forms.DateTimePicker _deliveryDatePicker;
        private System.Windows.Forms.Label pickupCodeLabel;
        private System.Windows.Forms.TextBox _pickupCodeBox;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}