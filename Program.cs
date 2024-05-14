using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_para_Iniciantesudemy;

namespace C_para_Iniciantesudemy
{
    public class Program
    {
        static void Main(string[] args)
        {
            dynamic idade = 18;

            if(!(idade < 18))
            {
                Console.WriteLine("Está liberado");
            } 
            else{
                Console.WriteLine("Não está liberado");
            }
        }
    }
}