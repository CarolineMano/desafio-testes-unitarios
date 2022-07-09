using Exercicio07.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio07
{
    [TestClass]
    public class SupervisorTests
    {
        private readonly Supervisor _supervisor;

        public SupervisorTests()
        {
            _supervisor = new Supervisor("Teste", 30, 2000);
        }

        [TestMethod]
        public void Dado_um_supervisor_cujo_salario_e_2000_a_bonificacao_deve_ser_7000()
        {
            Assert.AreEqual(7000, _supervisor.Bonificacao());
        }        
    }
}