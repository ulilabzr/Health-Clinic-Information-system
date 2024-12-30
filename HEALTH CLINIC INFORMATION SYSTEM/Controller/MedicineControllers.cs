using System.Collections.Generic;
using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Controllers
{
    public class MedicineController
    {
        private readonly IMedicineRepository _medicineRepository;

        public MedicineController(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }

        public async Task<IEnumerable<MedicineModel>> GetAllMedicinesAsync()
        {
            return await _medicineRepository.GetAllMedicinesAsync();
        }

        public async Task<MedicineModel> GetMedicineByIdAsync(int id)
        {
            return await _medicineRepository.GetMedicineByIdAsync(id);
        }

        public async Task AddMedicineAsync(MedicineModel medicine)
        {
            await _medicineRepository.AddMedicineAsync(medicine);
        }

        public async Task UpdateMedicineAsync(MedicineModel medicine)
        {
            await _medicineRepository.UpdateMedicineAsync(medicine);
        }

        public async Task DeleteMedicineAsync(int medicine_id)
        {
            await _medicineRepository.DeleteMedicineAsync(medicine_id);
        }
    }
}
