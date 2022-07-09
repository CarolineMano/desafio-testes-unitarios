using Exercicio07.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio07
{
    [TestClass]
    public class GerenteTests
    {
        private readonly Gerente _gerente;

        public GerenteTests()
        {
            _gerente = new Gerente("Teste", 35, 2000);
        }

        [TestMethod]
        public void Dado_um_gerente_cujo_salario_e_2000_a_bonificacao_deve_ser_12000()
        {
            Assert.AreEqual(12000, _gerente.Bonificacao());
        }               
    }
}