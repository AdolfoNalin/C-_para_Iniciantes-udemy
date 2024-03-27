using System;
using System.Collections.Generic;
using System.Data;
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
            int a = 10;
            int b = 20;
            int c = 200;

            if (a < b || a > c)
            {
                Console.WriteLine("É verdadeiro");
            }
            else if(a > c)
            {
                Console.WriteLine("Executou o Else if");
            }
            else
            {
                Console.WriteLine("É Mentira!");
            }
        }
    }
}