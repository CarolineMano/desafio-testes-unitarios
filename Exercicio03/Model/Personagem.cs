using System;

namespace Exercicio03.Model
{
    public class Personagem
    {
        public string Nome { get; protected set; }
        public int Vida { get; protected set; }
        public int Mana { get; protected set; }
        public double Xp { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Forca { get; protected set; }
        public int Level { get; protected set; }
        public static int NumeroPersonagens { get; private set; }
        public Personagem(string nome)
        {
            this.Nome = nome;
            this.Vida = 300;
            this.Mana = 50;
            this.Xp = 0;
            this.Inteligencia = 20;
            this.Forca = 20;
            this.Level = 1;
            NumeroPersonagens +=1;
        }
        public virtual void LvlUp()
        {
            this.Vida += 100;
            this.Mana += 30;
            this.Xp += 200;
            this.Inteligencia += 20;
            this.Forca += 20;
            this.Level += 1;
        }
        public virtual int Attack()
        {
            Random rnd = new Random();
            int ataque = rnd.Next(0, 301);
            return ataque;
        }
        public override string ToString()
        {
            return "\nNome: " + this.Nome + "\nVida: " + this.Vida
                + "\nMana: " + this.Mana + "\nXP: " + this.Xp +
                "\nInteligência: " + this.Inteligencia + "\nForça: "
                + this.Forca + "\nLevel: " + this.Level;
        }
        public static void MostrarNumeroPersonagens()
        {
            if(NumeroPersonagens == 1)
                Console.WriteLine($"\nFoi criado {NumeroPersonagens} personagem");
            else
                Console.WriteLine($"\nForam criados {NumeroPersonagens} personagens");
        }

    }
}