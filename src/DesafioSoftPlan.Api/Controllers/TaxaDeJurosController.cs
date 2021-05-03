using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DesafioSoftPlan.Api.Controllers
{
    [ApiController]
    [Route("taxaJuros")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class TaxaDeJurosController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Get()
        {
            return Ok(0.01);
        }
    }
}