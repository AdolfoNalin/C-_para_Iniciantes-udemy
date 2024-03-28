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
            while(contador <= 200)
            {
                Console.WriteLine($"{contador}KM /hora");
                contador++;
            }

            Console.WriteLine("você chegou no limite");
        } 
    }
}