using System;

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
            if (_valorInicial < 0) throw new ApplicationException("Valor inicial deve ser maior igual a zero.");
            if (_taxaDeJuros < 0) throw new ApplicationException("Taxa de juros deve ser maior igual a zero.");
            if (_tempoEmMeses < 0) throw new ApplicationException("Tempo em meses deve ser maior igual a zero.");

            var jurosCompostos = _valorInicial * Math.Pow(1 + _taxaDeJuros, _tempoEmMeses);

            return ObtemJurosCompostosTruncadoComDuasCasasDecimais(jurosCompostos);
        }

        private double ObtemJurosCompostosTruncadoComDuasCasasDecimais(double jurosCompostos)
        {
            return Math.Truncate(100 * jurosCompostos) / 100;
        }
    }
}
