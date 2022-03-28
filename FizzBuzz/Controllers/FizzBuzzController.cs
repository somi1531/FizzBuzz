using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace usage.tracking.request.service.Controllers
{

    public class FizzBuzzController : ControllerBase
    {

        private readonly IAssess _validate;

        public FizzBuzzController(IAssess validate)
        {
            _validate = validate;
        }

     

        [HttpGet]
        [Route("FizzBuzz/v1")]
        public async Task<IActionResult> FizzBuzz(string fizzBuzz)
        {
            var response = _validate.validateData(fizzBuzz.Split(',').ToList());
            return Ok(response);
        }

    }
}
