using Microsoft.EntityFrameworkCore;
using PSTests.Service.MedicineTracking.Repository.Models;

namespace PSTests.Service.MedicineTracking.Repository
{
    public class MedicineDbContext:DbContext
    {
        public MedicineDbContext()
        {

        }

        public MedicineDbContext(DbContextOptions<MedicineDbContext> options)
           : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
    }
}
