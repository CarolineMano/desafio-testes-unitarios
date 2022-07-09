using System.Collections.Generic;
using Exercicio02.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio02
{
    [TestClass]
    public class LojaTests
    {
        private readonly Livro _livro;
        private readonly VideoGame _videogame;
        private readonly Loja _lojaComProdutos;
        private readonly Loja _lojaSemProdutos;
        public LojaTests()
        {
            _livro = new Livro("Senhor dos Anéis", 100, 1, "J. R. R. Tolkien", "fantasia", 5000);
            _videogame = new VideoGame("PS4", 1000, 1, "Sony", "Slim", false);
            _lojaSemProdutos = new Loja("Americanas", "12345678", new List<Livro>(), new List<VideoGame>());
            _lojaComProdutos = new Loja("Americanas", "12345678", new List<Livro>{_livro}, new List<VideoGame>{_videogame});
        }

        [TestMethod]
        public void Dada_loja_com_livros_a_listagem_deve_retornar_true()
        {
            Assert.AreEqual(true, _lojaComProdutos.ListaLivros());
        }

        [TestMethod]
        public void Dada_loja_com_videogames_a_listagem_deve_retornar_true()
        {
            Assert.AreEqual(true, _lojaComProdutos.ListaVideoGames());
        }        

        [TestMethod]
        public void Dada_loja_sem_livros_a_listagem_deve_retornar_false()
        {
            Assert.AreEqual(false, _lojaSemProdutos.ListaLivros());
        }

        [TestMethod]
        public void Dada_loja_sem_videogames_a_listagem_deve_retornar_false()
        {
            Assert.AreEqual(false, _lojaSemProdutos.ListaVideoGames());
        }              

        [TestMethod]
        public void Dada_loja_com_um_livro_e_um_videogame_o_patrimonio_deve_ser_1100()
        {
            Assert.AreEqual(1100, _lojaComProdutos.CalculaPatrimonio());
        }

        [TestMethod]
        public void Dada_loja_sem_produtos_o_patrimonio_deve_ser_0()
        {
            Assert.AreEqual(0, _lojaSemProdutos.CalculaPatrimonio());
        }                                
    }
}