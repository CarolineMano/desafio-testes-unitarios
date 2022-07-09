using Exercicio01.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.Exercicio01
{
    [TestClass]
    public class VeiculoTests
    {
        private readonly Veiculo _veiculoDesligado;
        private readonly Veiculo _veiculoLigado;

        public VeiculoTests()
        {
            _veiculoDesligado = new Veiculo("Nissan", "Kicks", "YGH0E34", "Azul", 0, false, 10, 0, 98000);
            _veiculoLigado = new Veiculo("Nissan", "Kicks", "YGH0E34", "Azul", 0, true, 10, 30, 98000);
        }

        [TestMethod]
        public void Ao_acelerar_um_veiculo_a_30kmh_a_velocidade_devera_ser_50()
        {
            _veiculoLigado.Acelerar();
            Assert.AreEqual(50, _veiculoLigado.Velocidade);
        }

        [TestMethod]
        public void Ao_abastecer_um_tanque_de_60L_que_possui_10L_de_combustivel_com_mais_20L_total_deve_ser_30()
        {
            _veiculoDesligado.Abastecer(20);
            Assert.AreEqual(30, _veiculoDesligado.LitrosCombustivel);
        }

        [TestMethod]
        public void Ao_abastecer_um_tanque_de_60L_que_possui_10L_de_combustivel_com_mais_60L_total_deve_ser_10()
        {
            _veiculoDesligado.Abastecer(60);
            Assert.AreEqual(10, _veiculoDesligado.LitrosCombustivel);
        }        

        [TestMethod]
        public void Ao_abastecer_um_tanque_de_60L_que_possui_10L_de_combustivel_com_valor_negativo_total_deve_ser_10()
        {
            _veiculoDesligado.Abastecer(-1);
            Assert.AreEqual(10, _veiculoDesligado.LitrosCombustivel);
        } 

        [TestMethod]
        public void Ao_frear_um_veiculo_a_30kmh_a_velocidade_devera_ser_10()
        {
            _veiculoLigado.Frear();
            Assert.AreEqual(10, _veiculoLigado.Velocidade);
        }

        [TestMethod]
        public void Ao_frear_um_veiculo_a_30kmh_duas_vezes_a_velocidade_devera_ser_0()
        {
            _veiculoLigado.Frear();
            _veiculoLigado.Frear();            
            Assert.AreEqual(0, _veiculoLigado.Velocidade);
        }        

        [TestMethod]
        public void Ao_ligar_o_veiculo_desligado_ele_devera_se_encontrar_ligado()
        {
            _veiculoDesligado.Ligar();
            Assert.AreEqual(true, _veiculoDesligado.IsLigado);
        }     

        [TestMethod]
        public void Ao_ligar_o_veiculo_ligado_ele_devera_se_continuar_ligado()
        {
            _veiculoLigado.Ligar();            
            Assert.AreEqual(true, _veiculoLigado.IsLigado);
        }

        [TestMethod]
        public void Ao_desligar_o_veiculo_desligado_ele_devera_se_continuar_desligado()
        {
            _veiculoDesligado.Desligar();           
            Assert.AreEqual(false, _veiculoDesligado.IsLigado);
        }           

        [TestMethod]
        public void Ao_desligar_o_veiculo_ligado_ele_devera_se_encontrar_desligado()
        {
            _veiculoLigado.Desligar();           
            Assert.AreEqual(false, _veiculoLigado.IsLigado);
        }                                            
    }
}