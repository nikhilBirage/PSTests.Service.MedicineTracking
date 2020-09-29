using Microsoft.EntityFrameworkCore;
using PSTests.Service.MedicineTracking.Repository.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSTests.Service.MedicineTracking.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly MedicineDbContext _context;

        public MedicineRepository(MedicineDbContext context)
        {
            _context = context;
        }

        public async Task<Medicine> DeleteMedicine(int id)
        {
            var medicine = await _context.Medicines.FindAsync(id);

            _context.Medicines.Remove(medicine);

            await _context.SaveChangesAsync();

            return medicine;
        }

        public async Task<Medicine> GetMedicine(int id)
        {
            var medicine = await _context.Medicines.FindAsync(id);

            return medicine;
        }

        public async Task<IEnumerable<Medicine>> GetMedicines()
        {
            return await _context.Medicines.ToListAsync();
        }

        public async Task<bool> PostMedicine(Medicine medicine)
        {
            _context.Medicines.Add(medicine);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> PutMedicine(int id, Medicine medicine)
        {
            _context.Entry(medicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
