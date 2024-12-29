namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    partial class FrmMdclRecord
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
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(34, 273);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(323, 94);
            listBox1.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 23);
            textBox1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(467, 517);
            button2.Name = "button2";
            button2.Size = new Size(92, 38);
            button2.TabIndex = 28;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(568, 517);
            button1.Name = "button1";
            button1.Size = new Size(200, 38);
            button1.TabIndex = 27;
            button1.Text = "Save Record";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(34, 255);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 26;
            label8.Text = "Diagnosis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(34, 181);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 25;
            label6.Text = "Vital Signs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(34, 116);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 24;
            label4.Text = "Patient Name";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Plus Jakarta Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(288, 16);
            label1.Name = "label1";
            label1.Size = new Size(265, 40);
            label1.TabIndex = 23;
            label1.Text = "Medical Record Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 23);
            textBox2.TabIndex = 31;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(34, 402);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(323, 94);
            listBox2.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(34, 384);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 32;
            label2.Text = "Treatment Plan";
            // 
            // FrmMdclRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1__2_;
            ClientSize = new Size(951, 577);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FrmMdclRecord";
            Text = "FrmMdclRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label1;
        private TextBox textBox2;
        private ListBox listBox2;
        private Label label2;
    }
}