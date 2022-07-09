using Exercicio03.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio03
{
    [TestClass]
    public class PersonagemTests
    {
        private Personagem _personagem;

        public PersonagemTests()
        {
            _personagem = new Personagem("Personagem");
        }

        [TestMethod]      
        public void Dado_um_personagem_level_1_subir_de_level_deve_elevar_level_atual_para_2()
        {
            _personagem.LvlUp();
            Assert.AreEqual(2, _personagem.Level);
        }

        [TestMethod]       
        public void Dado_um_personagem_level_1_subir_de_level_deve_elevar_vida_atual_para_400()
        {
            _personagem.LvlUp();
            Assert.AreEqual(400, _personagem.Vida);
        }  

        [TestMethod]       
        public void Dado_um_personagem_level_1_subir_de_level_deve_elevar_mana_atual_para_80()
        {
            _personagem.LvlUp();
            Assert.AreEqual(80, _personagem.Mana);
        }          

        [TestMethod]      
        public void Dado_um_personagem_level_1_subir_de_level_deve_elevar_xp_atual_para_200()
        {
            _personagem.LvlUp();
            Assert.AreEqual(200, _personagem.Xp);
        }          

        [TestMethod]      
        public void Dado_um_personagem_level_1_subir_de_level_deve_elevar_inteligencia_atual_para_40()
        {
            _personagem.LvlUp();
            Assert.AreEqual(40, _personagem.Inteligencia);
        }                         

        [TestMethod] 
        public void Dado_um_personagem_level_1_subir_de_level_deve_elevar_forca_atual_para_40()
        {
            _personagem.LvlUp();
            Assert.AreEqual(40, _personagem.Forca);
        }             

        [TestMethod]
        // Este teste terá como valor 18 porque irá considerar todas as instâncias de personagem criadas a cada chamada de 
        // um método haverá a chamada do construtor. Como são 5 métodos nos GuerreirosTests, 5
        // no MagosTests e 7 no PersonagensTest, um dos quais cria dois personagens, o total é de 18 personagens.
        // Este método irá FALHAR se executado separadamente (cujo resultado esperado deve ser 2) ou se apenas a classe for
        // executada (cujo resultado esperado deve ser 8).
        public void Dada_a_criacao_de_um_novo_personagem_de_tipo_guerreiro_a_contagem_de_personagens_deve_ser_18()
        {
            var personagem = new Personagem("Novo personagem");
            Assert.AreEqual(18, Personagem.NumeroPersonagens);
        }           
    }
}