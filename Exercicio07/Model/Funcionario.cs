using System;

namespace Exercicio07.Model
{
    public class Funcionario
    {
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }
        public double Salario { get; protected set; }
        public string Cargo { get; protected set; }
        public Funcionario(string nome, int idade, double salario)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
            this.Cargo = "Cargo";
        }
        public virtual double Bonificacao()
        {
            return this.Salario;
        }

        public override string ToString()
        {
            return "\nNome: " + this.Nome + "\nCargo: " + this.Cargo + "\nIdade: " + 
                this.Idade + "\nSalário: R$" + String.Format("{0:0.00}", this.Salario) +
                "\nBonificação: R$" + String.Format("{0:0.00}", this.Bonificacao());
        }
    }
}