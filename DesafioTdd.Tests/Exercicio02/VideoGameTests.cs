using Exercicio02.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio02
{
    [TestClass]
    public class VideoGameTests
    {
        private readonly VideoGame _videogameNovo;
        private readonly VideoGame _videogameUsado;
        public VideoGameTests()
        {
            _videogameNovo = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            _videogameUsado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);            
        }

        [TestMethod]
        public void Imposto_videogame_novo_deve_ser_45_porcento()
        {
            Assert.AreEqual(0.45, _videogameNovo.CalculaImposto());
        }

        [TestMethod]
        public void Imposto_videogame_usado_deve_ser_25_porcento()
        {
            Assert.AreEqual(0.25, _videogameUsado.CalculaImposto());
        }        
    }
}