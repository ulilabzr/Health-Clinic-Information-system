namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    partial class FrmMdcnList
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
            button2 = new Button();
            btnAddMedicine = new Button();
            label1 = new Label();
            btnDelete = new Button();
            dataGridViewMedicines = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicines).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(514, 487);
            button2.Name = "button2";
            button2.Size = new Size(133, 53);
            button2.TabIndex = 16;
            button2.Text = "home";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(662, 487);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(241, 53);
            btnAddMedicine.TabIndex = 15;
            btnAddMedicine.Text = "Add Medicine";
            btnAddMedicine.UseVisualStyleBackColor = true;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(373, 36);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 13;
            label1.Text = "Medicine List";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(355, 487);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 53);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewMedicines
            // 
            dataGridViewMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicines.Location = new Point(24, 87);
            dataGridViewMedicines.Name = "dataGridViewMedicines";
            dataGridViewMedicines.Size = new Size(608, 237);
            dataGridViewMedicines.TabIndex = 18;
            // 
            // FrmMdcnList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1__2_;
            ClientSize = new Size(951, 577);
            Controls.Add(dataGridViewMedicines);
            Controls.Add(btnDelete);
            Controls.Add(button2);
            Controls.Add(btnAddMedicine);
            Controls.Add(label1);
            Name = "FrmMdcnList";
            Text = "FrmMdcnList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnAddMedicine;
        private Label label1;
        private Button btnDelete;
        private DataGridView dataGridViewMedicines;
    }
}