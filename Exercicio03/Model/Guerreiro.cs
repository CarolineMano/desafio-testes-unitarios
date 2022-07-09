using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio03.Model
{
    public class Guerreiro : Personagem
    {
        private IList<string> _habilidades;
        public IReadOnlyCollection<string> Habilidades { get {
            return _habilidades.ToArray();
        } }
        public Guerreiro(string nome) : base(nome)
        {
            this.Forca += 30;
            this.Vida += 100;
            _habilidades = new List<string>();
        }
        public override void LvlUp()
        {
            base.LvlUp();
            this.Forca += 20;
            this.Vida += 100;
        }
        public override int Attack()
        {
            int ataque = base.Attack() + this.Forca * this.Level;
            Console.WriteLine($"\n{this.Nome} ataca, dando {ataque} pontos de dano!");
            return ataque;            
        }

        public void AprenderHabilidade(string habilidade)
        {
            if(string.IsNullOrEmpty(habilidade))
                return;
            _habilidades.Add(habilidade);
            Console.WriteLine($"\n{this.Nome} aprendeu a habilidade {habilidade}");
        }

        public void MostrarHabilidades()
        {   
            Console.WriteLine($"\n-------Lista de Habilidades de {this.Nome}-------");
            for (int i = 0; i < Habilidades.Count; i++)
            {
                Console.WriteLine($"Habilidade {i+1}: {_habilidades[i]}");
            }
        }
    }
}