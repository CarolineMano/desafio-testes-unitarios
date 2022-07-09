using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio02.Model
{
    public class Loja
    {
        private IList<Livro> _livros;
        private IList<VideoGame> _videogames;
        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public IReadOnlyCollection<Livro> Livros  { get {
            return _livros.ToArray();
        } }
        public IReadOnlyCollection<VideoGame> VideoGames { get {
            return _videogames.ToArray();
        } }
        public Loja(){}
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            _livros = livros;
            _videogames = videoGames;    
        }

        public bool ListaLivros()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("A loja " + this.Nome + " possui estes livros para venda: ");
            if(this.Livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque");
                return false;
            }
            foreach (var livro in Livros)
            {
                Console.WriteLine(livro);
            }
            return true;
        }
        public bool ListaVideoGames()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("A loja " + this.Nome + " possui estes video-games para venda: ");
            if(this.VideoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem video-games no seu estoque");
                return false;
            }
            foreach (var videogame in VideoGames)
            {
                Console.WriteLine(videogame);
            }
            return true;
        }
        public double CalculaPatrimonio()
        {
            double patrimonio = 0;
            Console.WriteLine("---------------------------------------");
            if(this.Livros.Count != 0)
            {
                foreach (var livro in Livros)
                {
                    patrimonio += livro.Preco * livro.Qtd;
                }
            }
            if(this.VideoGames.Count != 0)
            {
                foreach (var videogame in VideoGames)
                {
                    patrimonio += videogame.Preco * videogame.Qtd;
                }
            }
            Console.WriteLine($"O patrimônio da loja {this.Nome} é de R$ {String.Format("{0:0.00}", patrimonio)}.");
            return patrimonio;
        }
    }
}