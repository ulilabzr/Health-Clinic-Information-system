using System.Collections.Generic;
using System.Threading.Tasks;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Context;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository;
using Microsoft.EntityFrameworkCore;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly AppDbContext _context;

        public MedicineRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MedicineModel>> GetAllMedicinesAsync()
        {
            return await _context.Medicine.ToListAsync();
        }

        public async Task<MedicineModel> GetMedicineByIdAsync(int medicine_id)
        {
            return await _context.Medicine.FindAsync(medicine_id);
        }

        public async Task AddMedicineAsync(MedicineModel medicine)
        {
            _context.Medicine.Add(medicine);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMedicineAsync(MedicineModel medicine)
        {
            _context.Medicine.Update(medicine);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMedicineAsync(int medicine_id)
        {
            var medicine = await _context.Medicine.FindAsync(medicine_id);
            if (medicine != null)
            {
                _context.Medicine.Remove(medicine);
                await _context.SaveChangesAsync();
            }
        }
    }
}
