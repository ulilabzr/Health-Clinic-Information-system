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
    public partial class FrmMdcnList : Form
    {
        private readonly MedicineController _medicineController;

        public FrmMdcnList()
        {
            InitializeComponent();
            var context = new AppDbContext();
            var medicineRepository = new MedicineRepository(context);
            _medicineController = new MedicineController(medicineRepository);
        }

        private async void FrmMdcnList_Load(object sender, EventArgs e)
        {
            await LoadMedicineListAsync();
        }

        private async Task LoadMedicineListAsync()
        {
            var medicines = await _medicineController.GetAllMedicinesAsync();
            dataGridViewMedicines.DataSource = medicines;
        }

        private async void btnAddMedicine_Click(object sender, EventArgs e)
        {
            using (var addMedicineForm = new FrmAddMdcn())
            {
                addMedicineForm.ShowDialog();
                await LoadMedicineListAsync(); // Refresh list after adding new medicine
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewMedicines.SelectedRows[0].Cells["medicine_Id"].Value;
                await _medicineController.DeleteMedicineAsync(id);
                MessageBox.Show("Medicine deleted successfully!");
                await LoadMedicineListAsync(); // Refresh list
            }
        }
    }
}
