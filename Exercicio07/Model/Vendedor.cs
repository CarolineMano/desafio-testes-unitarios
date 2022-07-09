namespace Exercicio07.Model
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
            Cargo = "Vendedor";
        }
        public override double Bonificacao()
        {
            return base.Bonificacao() + 3000;
        }
    }
}