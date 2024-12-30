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
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    public partial class FrmAddMdcn : Form

    {
        private readonly MedicineController _medicineController;
        public FrmAddMdcn()
        {
            InitializeComponent();
            var context = new AppDbContext();
            var medicineRepository = new MedicineRepository(context);
            _medicineController = new MedicineController(medicineRepository);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var medicine = new MedicineModel
            {
                name = txtMedicineName.Text,
                type = cmbType.SelectedItem.ToString(),
                stock = int.Parse(txtStock.Text),
                price = decimal.Parse(txtPrice.Text)
            };

            await _medicineController.AddMedicineAsync(medicine);
            MessageBox.Show("Medicine saved successfully!");
            // Reset form fields if needed

        }
    }
}
