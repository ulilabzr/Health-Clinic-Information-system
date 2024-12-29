namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    partial class FrmAdmstrnt
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
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            listView1 = new ListView();
            label4 = new Label();
            listView2 = new ListView();
            listView3 = new ListView();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(318, 32);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Administration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(44, 73);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(658, 73);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 2;
            label3.Text = "Payment Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(658, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Location = new Point(44, 129);
            listView1.Name = "listView1";
            listView1.Size = new Size(855, 293);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(44, 480);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 7;
            label4.Text = "Payment Status";
            // 
            // listView2
            // 
            listView2.Location = new Point(44, 504);
            listView2.Name = "listView2";
            listView2.Size = new Size(173, 32);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(658, 445);
            listView3.Name = "listView3";
            listView3.Size = new Size(241, 32);
            listView3.TabIndex = 10;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(541, 445);
            label5.Name = "label5";
            label5.Size = new Size(108, 21);
            label5.TabIndex = 9;
            label5.Text = "Total Amount";
            // 
            // button1
            // 
            button1.Location = new Point(658, 483);
            button1.Name = "button1";
            button1.Size = new Size(241, 53);
            button1.TabIndex = 11;
            button1.Text = "Print Nota";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(510, 483);
            button2.Name = "button2";
            button2.Size = new Size(133, 53);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmAdmstrnt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1__2_;
            ClientSize = new Size(951, 577);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView3);
            Controls.Add(label5);
            Controls.Add(listView2);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAdmstrnt";
            Text = "Administration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ListView listView1;
        private Label label4;
        private ListView listView2;
        private ListView listView3;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}