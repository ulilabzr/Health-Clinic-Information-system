namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    partial class FrmPrscrption
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(174, 385);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 94);
            listBox1.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(476, 520);
            button2.Name = "button2";
            button2.Size = new Size(92, 38);
            button2.TabIndex = 28;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(577, 520);
            button1.Name = "button1";
            button1.Size = new Size(200, 38);
            button1.TabIndex = 27;
            button1.Text = "Save Prescription";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(174, 367);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 26;
            label8.Text = "Instruction";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(174, 119);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 24;
            label4.Text = "Medicine Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Plus Jakarta Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(297, 19);
            label1.Name = "label1";
            label1.Size = new Size(226, 40);
            label1.TabIndex = 23;
            label1.Text = "Prescription Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(174, 176);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 32;
            label2.Text = "Dossage";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(174, 239);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 34;
            label3.Text = "Frequency";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 330);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(174, 307);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 36;
            label5.Text = "Quantity";
            // 
            // FrmPrscrption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1__2_;
            ClientSize = new Size(951, 577);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FrmPrscrption";
            Text = "FrmPrscrption";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
    }
}