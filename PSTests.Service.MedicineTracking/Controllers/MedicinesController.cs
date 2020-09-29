using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PSTests.Service.MedicineTracking.Repository;
using PSTests.Service.MedicineTracking.Repository.Models;

namespace PSTests.Service.MedicineTracking.Controllers
{
    [Route("api/medicines")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IMedicineRepository _repository;

        public MedicinesController(IMedicineRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Medicines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicine>>> GetMedicines()
        {
            return Ok(await _repository.GetMedicines());
        }

        // GET: api/Medicines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicine>> GetMedicine(int id)
        {
            var medicine = await _repository.GetMedicine(id);

            if (medicine == null)
            {
                return NotFound();
            }

            return medicine;
        }

        // PUT: api/Medicines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicine(int id, Medicine medicine)
        {
            if (id != medicine.Id)
            {
                return BadRequest();
            }
                

            await _repository.PutMedicine(id, medicine);
            

            return NoContent();
        }

        // POST: api/Medicines
        [HttpPost]
        public async Task<ActionResult<bool>> PostMedicine(Medicine medicine)
        {
            if (medicine == null)
            {
                return BadRequest();
            }

           var result = await _repository.PostMedicine(medicine);

           return Ok(result);
        }

        // DELETE: api/Medicines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteMedicine(int id)
        {
            var result = await _repository.DeleteMedicine(id);

            return Ok(result);
        }
    }
}
