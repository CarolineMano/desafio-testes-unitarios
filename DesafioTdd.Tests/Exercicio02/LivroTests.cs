using Exercicio02.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio02
{
    [TestClass]
    public class LivroTests
    {
        private readonly Livro _livroEducativo;
        private readonly Livro _livroFantasia;

        public LivroTests()
        {
            _livroFantasia = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 5000);
            _livroEducativo = new Livro(".NET", 20, 50, "GFT", "educativo", 500);            
        }

        [TestMethod]
        public void Imposto_livro_educativo_deve_ser_0()
        {
            Assert.AreEqual(0, _livroEducativo.CalculaImposto());
        }

        [TestMethod]
        public void Imposto_livro_nao_educativo_deve_ser_10_porcento()
        {
            Assert.AreEqual(0.1, _livroFantasia.CalculaImposto());
        }        
    }
}