using HEALTH_CLINIC_INFORMATION_SYSTEM.Visual;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // buat objek form login
            FrmLogin frmLogin = new FrmLogin();

            // tampilkan form login
            if (frmLogin.ShowDialog() == DialogResult.OK) // jika user dan password benar
            {
                // cek tipe pengguna berdasarkan data login
                if (frmLogin.UserType == "Doctor") // jika user adalah dokter
                {
                    Application.Run(new FrmDshbrdDctr()); // jalankan form dashboard dokter
                }
                else if (frmLogin.UserType == "Admin") // jika user adalah admin
                {
                    Application.Run(new FrmDshbrdAdmin()); // jalankan form dashboard admin
                }
                else
                {
                    MessageBox.Show("User type tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // keluar dari aplikasi
                }
            }
            else
                Application.Exit(); // keluar dari aplikasi
        }
    }
}