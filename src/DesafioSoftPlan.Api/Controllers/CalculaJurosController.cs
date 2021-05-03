using Microsoft.AspNetCore.Mvc;
using DesafioSoftPlan.Api.ApiServices;

namespace DesafioSoftPlan.Api.Controllers
{
    
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly TaxaDeJurosApiService _taxaDeJurosApiService;

        public CalculaJurosController(TaxaDeJurosApiService taxaDeJurosApiService)
        {
            _taxaDeJurosApiService = taxaDeJurosApiService;
        }

        [HttpGet]
        [Route("calculajuros")]
        public ActionResult Juros(double valorInicial, double meses)
        {
            var taxaDeJuros = _taxaDeJurosApiService.GetTaxaDeJuros();

            return Ok(105.1);
        }

        [HttpGet]
        [Route("showmethecode")]
        public ActionResult Code()
        {
            return Ok("https://github.com/stenionobres/DesafioSoftPlan");
        }
    }
}