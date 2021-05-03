using Microsoft.AspNetCore.Mvc;

namespace DesafioSoftPlan.Api.Controllers
{
    
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        [Route("showmethecode")]
        public ActionResult Code()
        {
            return Ok("https://github.com/stenionobres/DesafioSoftPlan");
        }
    }
}