using PSTests.Service.MedicineTracking.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSTests.Service.MedicineTracking.Repository
{
    public interface IMedicineRepository
    {
        Task<IEnumerable<Medicine>> GetMedicines();

        Task<Medicine> GetMedicine(int id);

        Task<bool> PutMedicine(int id, Medicine medicine);

        Task<bool> PostMedicine(Medicine medicine);

        Task<Medicine> DeleteMedicine(int id);
    }
}
