using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__ParaIniciantes
{
    public class Filme
    {
        public int Id { get; set; }
        public string nome;
        public string descricao;
        public int ano;
        public string studio;
        private List<string> atores = new List<string>();

        public Filme(int id, string nome, string descricao, int ano,string studio)
        {
            this.Id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.ano = ano;
            this.studio = studio;
            this.atores = atores;
        }

        public void Executar()
        {
            Console.WriteLine("Rodando o filme: " + this.nome);
        }

        static public void Pausar()
        {
            Console.WriteLine("||");
        }

        public void SetAtor(string nome)
        {
            if(nome != null && nome != String.Empty){
                
                if(nome.Length > 4)
                {
                    atores.Add(nome);
                }
            }
        }

        public void GetAtores()
        {
            foreach(string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }
    }
}