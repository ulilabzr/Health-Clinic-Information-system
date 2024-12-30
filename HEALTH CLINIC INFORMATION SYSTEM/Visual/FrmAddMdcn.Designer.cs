namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    partial class FrmAddMdcn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtMedicineName = new TextBox();
            txtStock = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbType = new ComboBox();
            btnSave = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(355, 48);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 0;
            label1.Text = "Medicine Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(62, 99);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 1;
            label2.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            txtMedicineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMedicineName.Location = new Point(62, 123);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(249, 29);
            txtMedicineName.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(459, 123);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(249, 29);
            txtStock.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(459, 99);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 3;
            label3.Text = "Stock";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(459, 228);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(249, 29);
            txtPrice.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(459, 204);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(62, 204);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 7;
            label5.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.Font = new Font("Segoe UI", 12F);
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Table", "Capsule", "Ointment", "Bottle" });
            cmbType.Location = new Point(62, 234);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(249, 29);
            cmbType.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(509, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 49);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save Medicine";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(369, 289);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 49);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // FrmAddMdcn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1__2_;
            ClientSize = new Size(951, 577);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(cmbType);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtMedicineName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddMdcn";
            Text = "Add Medicine Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMedicineName;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private Label label5;
        private ComboBox cmbType;
        private Button btnSave;
        private Button btnReset;
    }
}