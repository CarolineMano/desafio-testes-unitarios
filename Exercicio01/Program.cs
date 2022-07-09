using System;
using Exercicio01.Model;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Nissan", "Kicks", "YGH0E34", "Azul", 0, false, 10, 0, 98000);
            veiculo.Abastecer(30);
            Console.WriteLine(veiculo);
            veiculo.Abastecer(30);
            Console.WriteLine(veiculo);
            veiculo.Acelerar();
            Console.WriteLine(veiculo);
            veiculo.Frear();
            Console.WriteLine(veiculo);
            veiculo.Pintar("Branco");
            Console.WriteLine(veiculo);
            veiculo.Ligar();
            Console.WriteLine(veiculo);
            veiculo.Desligar();
            Console.WriteLine(veiculo);
        }
    }
}
