using DesafioSoftPlan.Negocio;

namespace DesafioSoftPlan.Api.Services
{
    public class JurosCompostosService
    {
        public double Calcular(double valorInicial, double taxaDeJuros, double tempoEmMeses)
        {
            var jurosCompostos = new JurosCompostos(valorInicial, taxaDeJuros, tempoEmMeses);

            return jurosCompostos.calcular();
        }
    }
}
