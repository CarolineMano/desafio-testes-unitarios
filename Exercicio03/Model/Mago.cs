using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio03.Model
{
    public class Mago : Personagem
    {
        private IList<string> _magias;
        public IReadOnlyCollection<string> Magias { get {
            return _magias.ToArray();
        }}
        public Mago(string nome) : base(nome) 
        {
            this.Mana += 30;
            this.Inteligencia += 40;
            _magias = new List<string>();
        }
        public override void LvlUp()
        {
            base.LvlUp();
            this.Mana += 30;
            this.Inteligencia += 20;
        }
        public override int Attack()
        {
            int ataque = base.Attack() + this.Inteligencia * this.Level;
            Console.WriteLine($"\n{this.Nome} ataca, dando {ataque} pontos de dano!");
            return ataque;            
        }

        public void AprenderMagia(string magia)
        {
            if(string.IsNullOrEmpty(magia))
                return;            
            _magias.Add(magia);
            Console.WriteLine($"\n{this.Nome} aprendeu a magia {magia}");
        }

        public void MostrarMagias()
        {
            Console.WriteLine($"\n-------Lista de Magias de {this.Nome}-------");
            for (int i = 0; i < Magias.Count; i++)
            {
                Console.WriteLine($"Magia {i+1}: {_magias[i]}");
            }
        }
    }
}