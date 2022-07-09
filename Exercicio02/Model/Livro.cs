using System;
using Exercicio02.Interface;

namespace Exercicio02.Model
{
    public class Livro : Produto, IImposto
    {
        public string Autor { get; private set; }
        public string Tema { get; private set; }
        public int QtdPag { get; private set; }
        public Livro() {}
        public Livro(string nome, double preco, int qtd, 
            string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            this.Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        public double CalculaImposto()
        {
            if(this.Tema.ToUpper().Equals("EDUCATIVO"))
            {
                Console.WriteLine($"Livro educativo não tem imposto: {this.Nome}.");
                return 0;
            }
            Console.WriteLine($"R$ {String.Format("{0:0.00}", this.Preco*0.10)} de impostos sobre o livro {this.Nome}.");
            return 0.1;
        }
        public override string ToString()
        {
            return "Título: " + this.Nome + ", preço: R$" + String.Format("{0:0.00}", this.Preco) + 
                ", quantidade: " + this.Qtd + " em estoque.";
        }
    }
}