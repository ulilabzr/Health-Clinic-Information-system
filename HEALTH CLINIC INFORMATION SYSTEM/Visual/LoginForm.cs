using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Context;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Controllers;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    public partial class LoginForm : Form
    {
        private readonly LoginController _loginController;
        public LoginForm()
        {
            InitializeComponent();
            var context = new AppDbContext();
            var userRepository = new UserRepository(context);
            _loginController = new LoginController(userRepository);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var isAuthenticated = await _loginController.AuthenticateAsync(txtUsername.Text, txtPassword.Text);
            if (isAuthenticated)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    MessageBox.Show("Login successful! Redirecting to Admin Dashboard.");
                    FrmDshbrdAdmin adminDashboard = new FrmDshbrdAdmin();
                    adminDashboard.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Login successful! Redirecting to Doctor Dashboard.");
                    FrmDshbrdDctr doctorDashboard = new FrmDshbrdDctr();
                    doctorDashboard.Show();
                    this.Hide(); 
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }

    }
}

