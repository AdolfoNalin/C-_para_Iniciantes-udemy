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
          int contador = 1000;

          for(int i = contador; i >= 0; --i)
          {
            if(i > 10)
            {
                Console.WriteLine($"Contador está: {i}");
            }
            else
            {
                Console.WriteLine($"{i}");
            }
          }

          Console.WriteLine("---------LANÇADO---------");
        } 
    }
}