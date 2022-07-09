using Exercicio03.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio03
{
    [TestClass]
    public class MagoTests
    {
        private readonly Mago _mago;

        public MagoTests()
        {
            _mago = new Mago("Cyrus");
        }

        [TestMethod]
        public void Dado_um_mago_level_1_subir_de_level_deve_elevar_level_atual_para_2()
        {
            _mago.LvlUp();
            Assert.AreEqual(2, _mago.Level);
        }        

        [TestMethod]
        public void Dado_um_mago_level_1_subir_de_level_deve_elevar_mana_atual_para_140()
        {
            _mago.LvlUp();
            Assert.AreEqual(140, _mago.Mana);
        }            

        [TestMethod]
        public void Dado_um_mago_level_1_subir_de_level_deve_elevar_inteligencia_atual_para_100()
        {
            _mago.LvlUp();
            Assert.AreEqual(100, _mago.Inteligencia);
        }                

        [TestMethod]
        public void Dado_um_mago_sem_magia_aprender_nova_deve_elevar_a_quantidade_para_1()
        {
            _mago.AprenderMagia("Fireball");
            Assert.AreEqual(1, _mago.Magias.Count);
        }            

        [TestMethod]
        public void Dado_um_mago_sem_magia_aprender_magia_vazia_deve_manter_a_quantidade_em_0()
        {
            _mago.AprenderMagia("");
            Assert.AreEqual(0, _mago.Magias.Count);
        }                    
    }
}