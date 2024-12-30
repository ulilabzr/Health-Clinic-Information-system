using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    public partial class FrmDshbrdAdmin : Form
    {
        public FrmDshbrdAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Logout");
            LoginForm loginpage = new LoginForm();
            loginpage.Show();
            this.Close();
        }
    }
}
