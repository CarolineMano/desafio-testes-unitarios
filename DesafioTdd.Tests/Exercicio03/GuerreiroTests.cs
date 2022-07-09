using Exercicio03.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio03
{
    [TestClass]
    public class GuerreiroTests
    {
        private readonly Guerreiro _guerreiro;

        public GuerreiroTests()
        {
            _guerreiro = new Guerreiro("Olberic");
        }

        [TestMethod]
        public void Dado_um_guerreiro_level_1_subir_de_level_deve_elevar_level_atual_para_2()
        {
            _guerreiro.LvlUp();
            Assert.AreEqual(2, _guerreiro.Level);
        }

        [TestMethod]
        public void Dado_um_guerreiro_level_1_subir_de_level_deve_elevar_forca_atual_para_90()
        {
            _guerreiro.LvlUp();
            Assert.AreEqual(90, _guerreiro.Forca);
        }        

        [TestMethod]
        public void Dado_um_guerreiro_level_1_subir_de_level_deve_elevar_vida_atual_para_600()
        {
            _guerreiro.LvlUp();
            Assert.AreEqual(600, _guerreiro.Vida);
        }       

        [TestMethod]
        public void Dado_um_guerreiro_sem_habilidade_aprender_nova_deve_elevar_a_quantidade_para_1()
        {
            _guerreiro.AprenderHabilidade("Spearhead");
            Assert.AreEqual(1, _guerreiro.Habilidades.Count);
        }  

        [TestMethod]
        public void Dado_um_guerreiro_sem_habilidade_aprender_habilidade_vazia_deve_manter_a_quantidade_em_0()
        {
            _guerreiro.AprenderHabilidade("");
            Assert.AreEqual(0, _guerreiro.Habilidades.Count);
        }          
    }
}