namespace DojoPuzzle.Model
{
    public class IndiceDeEquilibrio
    {
        public int RetornaIndiceDeEquilibrio(int[] vetorDeTeste)
        {
            int somaEsquerda = 0;
            int somaDireita = 0;

            for (int i = 0; i < vetorDeTeste.Length - 2; i++)
            {
                somaEsquerda += vetorDeTeste[i];
            }

            for (int j = vetorDeTeste.Length - 1; j > 1; j--)
            {
                somaDireita += vetorDeTeste[j];

                if(somaDireita == somaEsquerda)
                    return (j - 1);
                
                somaEsquerda -= vetorDeTeste[j -2];
            }

            return -1;
        }
    }
}