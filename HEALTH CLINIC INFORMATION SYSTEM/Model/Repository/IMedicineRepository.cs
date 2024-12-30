using System.Collections.Generic;
using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;


namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository
{
    public interface IMedicineRepository
    {
        Task<IEnumerable<MedicineModel>> GetAllMedicinesAsync();
        Task<MedicineModel> GetMedicineByIdAsync(int medicine_id);
        Task AddMedicineAsync(MedicineModel medicine);
        Task UpdateMedicineAsync(MedicineModel medicine);
        Task DeleteMedicineAsync(int medicine_id);
    }
}
