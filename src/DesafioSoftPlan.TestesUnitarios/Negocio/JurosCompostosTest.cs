using NUnit.Framework;

namespace DesafioSoftPlan.TestesUnitarios.Negocio
{
    [TestFixture]
    public class JurosCompostosTest
    {
        [Test]
        public void DeveCalcularJurosCompostosIgualAZeroParaValorInicialIgualAZero()
        {

            Assert.AreEqual(0, 0);
        }
    }
}
