
namespace DesafioSoftPlan.Negocio
{
    public class JurosCompostos
    {
        private readonly double _valorInicial;
        private readonly double _taxaDeJuros;
        private readonly double _tempoEmMeses;

        public JurosCompostos(double valorInicial, double taxaDeJuros, double tempoEmMeses)
        {
            _valorInicial = valorInicial;
            _taxaDeJuros = taxaDeJuros;
            _tempoEmMeses = tempoEmMeses;
        }

        public double calcular()
        {
            return _valorInicial;
        }
    }
}
