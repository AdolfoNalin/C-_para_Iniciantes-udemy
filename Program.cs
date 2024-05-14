using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__ParaIniciantes;
using C_para_Iniciantesudemy.Objects.Formas;

namespace C_para_Iniciantesudemy
{
    public class Program
    {

        static void Main(string[] args)
        {
            Filme filme1 = new Filme(1, nome: "Era do Gelo",descricao: "...", 2004, "");
            Filme filme2 = filme1;
            Filme filme3 = filme2;

            Console.WriteLine(filme3.nome);

            filme1.nome = "Irom man";

            Console.WriteLine(filme3.nome);

            filme3.nome = "Meu malvado favorito!";

            Console.WriteLine(filme2.nome);
        }
    }
}