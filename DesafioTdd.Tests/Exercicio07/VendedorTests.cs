using Exercicio07.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio07
{
    [TestClass]
    public class VendedorTests
    {
        private readonly Vendedor _vendedor;

        public VendedorTests()
        {
            _vendedor = new Vendedor("Teste", 25, 2000);
        }

        [TestMethod]
        public void Dado_um_vendedor_cujo_salario_e_2000_a_bonificacao_deve_ser_5000()
        {
            Assert.AreEqual(5000, _vendedor.Bonificacao());
        }
    }
}