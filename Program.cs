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
            Console.WriteLine("Insira 3 numeros para saber qual é o maior ou se são iguais");
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            double num3 = Double.Parse(Console.ReadLine());

            if(num1 < num2)
            {
                if(num1 < num3)
                {
                    Console.WriteLine("O maior número é: " + num1);
                }
            }
            else if(num2 < num3)
            {
                Console.WriteLine("O maior número é: " + num2);
            }
            else if (num3 < num1)
            {
                Console.WriteLine("O maior número é: " + num3);
            }
            else
            {
                Console.WriteLine("São todos iguais");
            }
        }
    }
}