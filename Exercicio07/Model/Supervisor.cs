namespace Exercicio07.Model
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario) 
        {
            Cargo = "Supervisor";
        }
        public override double Bonificacao()
        {
            return base.Bonificacao() + 5000;
        }
    }
}