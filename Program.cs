using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using C_Para_Iniciantes;

namespace C_Para_Iniciantes
{
    class Program
    {
        static void Main(String[] angs)
        {
            string[] produtos = new string[5]
            {
                "Sea of thiseves",
                "FIFA",
                "Minecraft",
                "Half-Life",
                "Portal"
            };

            Console.WriteLine(produtos[1]);

            int[] valore = {40,50,60,70,20};

            Console.WriteLine(valore[4]);
        }
    }
}