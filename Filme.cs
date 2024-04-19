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
        public List<string> atores = new List<string>();

        public void Executar()
        {
            Console.WriteLine("Rodando o filme: " + this.nome);
        }

        static public void Pausar()
        {
            Console.WriteLine("||");
        }
    }
}