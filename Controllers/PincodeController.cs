using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IndianPincode.Data;
using IndianPincode.Models;

namespace IndianPincode.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PincodeController : ControllerBase
    {
        private readonly PincodeContext _context;

        public PincodeController(PincodeContext context)
        {
            _context = context;
        }

        [HttpGet("{pincode}")]
        public async Task<IActionResult> GetByPincode(int pincode)
        {
            var results = await _context.IndiaPincodeData
                .FromSqlRaw("SELECT circlename, regionname, divisionname, officename, pincode, officetype, delivery, district, statename, latitude, longitude FROM dbo.[IndiaPincodeData ] WHERE pincode = {0}", pincode)
                .ToListAsync();

            return Ok(results);
        }
    }
}
