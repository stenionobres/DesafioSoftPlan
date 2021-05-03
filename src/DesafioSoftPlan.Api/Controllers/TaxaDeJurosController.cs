using Microsoft.AspNetCore.Mvc;

namespace DesafioSoftPlan.Api.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(0.01);
        }
    }
}