namespace Exercicio07.Model
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario) 
        {
            Cargo = "Gerente";
        }


        public override double Bonificacao()
        {
            return base.Bonificacao() + 10000;
        }
    }
}