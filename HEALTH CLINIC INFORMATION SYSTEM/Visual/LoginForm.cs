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
                MessageBox.Show("Login successful!");
                // Lanjutkan ke form berikutnya atau halaman utama aplikasi
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
            }
        }
    }
}
