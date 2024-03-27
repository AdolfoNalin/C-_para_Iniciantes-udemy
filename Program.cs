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
            Console.WriteLine("Por favor digite a sua idade!");
            int idade = int.Parse(Console.ReadLine());

        
            if(idade > 0 && idade <= 10)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if(idade > 10 && idade < 18)
            {
                Console.WriteLine("Você é um adolecente");
            }
            else if (idade >= 18 && idade < 60)
            {
                Console.WriteLine("você é um adulto");
            }
            else{
                Console.WriteLine("Você é um idoso");
            }
        
        }
    }
}