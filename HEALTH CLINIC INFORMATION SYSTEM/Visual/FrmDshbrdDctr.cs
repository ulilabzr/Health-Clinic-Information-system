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
    public partial class FrmDshbrdDctr : Form
    {
        public FrmDshbrdDctr()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Logout");
            LoginForm loginpage = new LoginForm();
            loginpage.Show();
            this.Close();
        }
    }
}
