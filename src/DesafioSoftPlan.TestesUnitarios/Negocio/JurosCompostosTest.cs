using System;
using NUnit.Framework;
using DesafioSoftPlan.Negocio;

namespace DesafioSoftPlan.TestesUnitarios.Negocio
{
    [TestFixture]
    public class JurosCompostosTest
    {
        [Test]
        public void DeveLancarExcecaoParaValorInicialMenorQueZero()
        {
            var jurosCompostos = new JurosCompostos(valorInicial: -1, taxaDeJuros: 1, tempoEmMeses: 1);
            var exception = Assert.Throws<ApplicationException>(() => jurosCompostos.calcular());

            Assert.That(exception.Message, Is.EqualTo("Valor inicial deve ser maior igual a zero."));
        }

        [Test]
        public void DeveCalcularJurosCompostosIgualAZeroParaValorInicialIgualAZero()
        {
            var jurosCompostos = new JurosCompostos(valorInicial: 0, taxaDeJuros: 1, tempoEmMeses: 1);

            Assert.AreEqual(0, jurosCompostos.calcular());
        }

        [Test]
        public void DeveLancarExcecaoParaTaxaDeJurosMenorQueZero()
        {
            var jurosCompostos = new JurosCompostos(valorInicial: 20, taxaDeJuros: -1, tempoEmMeses: 1);
            var exception = Assert.Throws<ApplicationException>(() => jurosCompostos.calcular());

            Assert.That(exception.Message, Is.EqualTo("Taxa de juros deve ser maior igual a zero."));
        }

        [Test]
        public void DeveCalcularJurosCompostosIgualAValorInicialParaTempoEmMesesIgualAZero()
        {
            var valorInicial = 100;
            var jurosCompostos = new JurosCompostos(valorInicial: valorInicial, taxaDeJuros: 1, tempoEmMeses: 0);

            Assert.AreEqual(valorInicial, jurosCompostos.calcular());
        }

        [Test]
        public void DeveLancarExcecaoParaTempoEmMesesMenorQueZero()
        {
            var jurosCompostos = new JurosCompostos(valorInicial: 20, taxaDeJuros: 0.5, tempoEmMeses: -1);
            var exception = Assert.Throws<ApplicationException>(() => jurosCompostos.calcular());

            Assert.That(exception.Message, Is.EqualTo("Tempo em meses deve ser maior igual a zero."));
        }
    }
}
