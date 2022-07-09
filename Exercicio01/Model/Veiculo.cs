using System;

namespace Exercicio01.Model
{
    public class Veiculo 
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public bool IsLigado { get; private set; }
        public int LitrosCombustivel { get; private set; }
        public int Velocidade { get; private set; }
        public double Preco { get; private set; }

        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Km = km;
            this.IsLigado = isLigado;
            this.LitrosCombustivel = litrosCombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }
        public void Acelerar()
        {
            this.Velocidade += 20;
        }
        public void Abastecer(int combustivel)
        {
            if(combustivel < 0)
                return;
                
            if(LitrosCombustivel + combustivel <= 60)
                this.LitrosCombustivel += combustivel;

            else
                Console.WriteLine($"Tanque irá transbordar. Abasteça com até {60 - this.LitrosCombustivel}");
        }
        public void Frear()
        {
            if(this.Velocidade < 20)
                this.Velocidade = 0;
            else
               this.Velocidade -= 20;
        }
        public void Pintar(String cor)
        {
            this.Cor = cor;
        }
        public void Ligar()
        {
            if(!this.IsLigado)
                this.IsLigado = true;
        }
        public void Desligar()
        {
            if(this.IsLigado)
                this.IsLigado = false;
        }

        public override string ToString()
        {
            string saida = "\nMarca: " + this.Marca + "\nModelo: " +
                this.Modelo + "\nPlaca: " + this.Placa + "\nCor: " +
                this.Cor + "\nKM: " + this.Km + "\nEstá ligado? " +
                this.IsLigado + "\nLitros de Combustível: " + 
                this.LitrosCombustivel+ "\nVelocidade: " + 
                this.Velocidade + "\nPreço: R$" + String.Format("{0:0.00}", this.Preco);
            return saida;
        }
    }
}