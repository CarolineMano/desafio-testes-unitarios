using Exercicio07.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio07
{
    [TestClass]
    public class FuncionarioTests
    {
        private readonly Funcionario _funcionario;

        public FuncionarioTests()
        {
            _funcionario = new Funcionario("Teste", 32, 2000);
        }

        [TestMethod]
        public void Dado_um_funcionario_a_bonificacao_deve_ser_igual_ao_salario()
        {
            Assert.AreEqual(_funcionario.Salario, _funcionario.Bonificacao());
        }
    }
}