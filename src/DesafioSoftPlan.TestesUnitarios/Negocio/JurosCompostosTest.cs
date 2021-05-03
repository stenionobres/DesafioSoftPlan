using NUnit.Framework;
using DesafioSoftPlan.Negocio;

namespace DesafioSoftPlan.TestesUnitarios.Negocio
{
    [TestFixture]
    public class JurosCompostosTest
    {
        [Test]
        public void DeveCalcularJurosCompostosIgualAZeroParaValorInicialIgualAZero()
        {
            var jurosCompostos = new JurosCompostos(valorInicial: 0, taxaDeJuros: 1, tempoEmMeses: 1);

            Assert.AreEqual(0, jurosCompostos.calcular());
        }
    }
}
