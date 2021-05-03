using Microsoft.AspNetCore.Mvc;
using DesafioSoftPlan.Api.ApiServices;
using DesafioSoftPlan.Api.Services;
using Microsoft.AspNetCore.Http;

namespace DesafioSoftPlan.Api.Controllers
{
    
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly TaxaDeJurosApiService _taxaDeJurosApiService;
        private readonly JurosCompostosService _jurosCompostosService;

        public CalculaJurosController(TaxaDeJurosApiService taxaDeJurosApiService, JurosCompostosService jurosCompostosService)
        {
            _taxaDeJurosApiService = taxaDeJurosApiService;
            _jurosCompostosService = jurosCompostosService;
        }

        [HttpGet]
        [Route("calculajuros")]
        public ActionResult Juros(double valorInicial, double meses)
        {
            try
            {
                var taxaDeJuros = _taxaDeJurosApiService.GetTaxaDeJuros();
                var valorDosJurosCompostos = _jurosCompostosService.Calcular(valorInicial, taxaDeJuros, meses);

                return Ok(valorDosJurosCompostos);
            }
            catch (System.ApplicationException ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A server error has occurred");
            }
            
        }

        [HttpGet]
        [Route("showmethecode")]
        public ActionResult Code()
        {
            return Ok("https://github.com/stenionobres/DesafioSoftPlan");
        }
    }
}