using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using C_Para_Iniciantes;

namespace C_Para_Iniciantes
{
    enum cor {Azul, Verde, Amarelo = 33, Vermelho = 1000}
    class Program
    {
        static void Main(String[] angs)
        {
            cor corFavorita = cor.Verde;
            Console.WriteLine(corFavorita);
            Console.WriteLine((int)corFavorita);
            Console.WriteLine((cor) 1000);
        }
    }
}