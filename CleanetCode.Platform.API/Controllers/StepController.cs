using Microsoft.AspNetCore.Mvc;

namespace CleanetCode.Platform.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StepController : Controller
    {

        public StepController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok();

        [HttpPost]
        public async Task<IActionResult> Create() => Ok();

        [HttpPut]
        public async Task<IActionResult> Update() => Ok();

        [HttpDelete]
        public async Task<IActionResult> Delete() => Ok();
    }
}
