using System;
using Exercicio02.Interface;

namespace Exercicio02.Model
{
    public class VideoGame : Produto, IImposto
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public bool IsUsado { get; private set; }
        public VideoGame(){}
        public VideoGame(string nome, double preco, int qtd, 
            string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }
        public double CalculaImposto()
        {
            if(this.IsUsado)
            {
                Console.WriteLine($"Imposto {this.Nome} {this.Modelo} usado R${String.Format("{0:0.00}", this.Preco*0.25)}.");
                return 0.25;
            }
            Console.WriteLine($"Imposto {this.Nome} {this.Modelo} R${String.Format("{0:0.00}", this.Preco*0.45)}.");
            return 0.45;
        }

        public override string ToString()
        {
            return "Video-game: " + this.Modelo + ", preço: R$" + String.Format("{0:0.00}", this.Preco) + 
                ", quantidade: " + this.Qtd + " em estoque.";
        }
    }
}