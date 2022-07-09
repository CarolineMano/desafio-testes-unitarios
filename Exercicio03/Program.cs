using System;
using Exercicio03.Model;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago = new Mago("Cyrus");
            Personagem.MostrarNumeroPersonagens();
            Guerreiro guerreiro = new Guerreiro("Olberic");
            Personagem.MostrarNumeroPersonagens();

            Console.WriteLine(mago);
            Console.WriteLine(guerreiro);

            mago.LvlUp();
            guerreiro.LvlUp();

            Console.WriteLine(mago);
            Console.WriteLine(guerreiro);

            mago.Attack();
            guerreiro.Attack();
            mago.Attack();
            guerreiro.Attack();

            mago.LvlUp();
            guerreiro.LvlUp();

            Console.WriteLine(mago);
            Console.WriteLine(guerreiro);

            Personagem.MostrarNumeroPersonagens();

            mago.AprenderMagia("Fireball");
            mago.AprenderMagia("Hail");

            guerreiro.AprenderHabilidade("Slash");
            guerreiro.AprenderHabilidade("Pierce");

            mago.MostrarMagias();
            guerreiro.MostrarHabilidades();
        }
    }
}
