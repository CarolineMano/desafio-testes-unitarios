using DojoPuzzle.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTdd.Tests.DojoPuzzle
{
    [TestClass]
    public class IndiceDeEquilibrioTests
    {
        private readonly IndiceDeEquilibrio _exercicio;
        private readonly int[] _arrayExercicio;
        private readonly int[] _arrayIndice1;
        private readonly int[] _arrayNaoPossuiIndice;

        public IndiceDeEquilibrioTests()
        {
            _arrayExercicio = new int[] {-7, 1, 5, 2, -4, 3, 0};
            _arrayIndice1 = new int[] {15, 1, 2, 5, 0, 3, 5};
            _arrayNaoPossuiIndice = new int[] {1, 5, 3, 10};
            _exercicio = new IndiceDeEquilibrio();
        }

        [TestMethod]
        public void Dado_um_vetor_com_indice_de_equilibrio_3_o_resultado_deve_ser_3()
        {
            int resultado = _exercicio.RetornaIndiceDeEquilibrio(_arrayExercicio);

            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void Dado_um_vetor_sem_indice_de_equilibrio_o_resultado_deve_ser_1_negativo()
        {
            int resultado = _exercicio.RetornaIndiceDeEquilibrio(_arrayNaoPossuiIndice);

            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void Dado_um_vetor_com_indice_de_equilibrio_1_o_resultado_deve_ser_1()
        {
            int resultado = _exercicio.RetornaIndiceDeEquilibrio(_arrayIndice1);

            Assert.AreEqual(1, resultado);
        }        
    }
}