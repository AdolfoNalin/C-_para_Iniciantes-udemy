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
    class Program
    {
        static void Main(String[] angs)
        {
            int contador = 0;
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador < 3);
            
        } 
    }
}