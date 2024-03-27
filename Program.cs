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
            Console.WriteLine("Qual é a sua nessecidade?");
            int urgencia = int.Parse(Console.ReadLine());

            if(urgencia >= 0)
            {
                if(urgencia <= 3)
                {
                    Console.WriteLine("Baixa");
                }
                else if(urgencia <= 6)
                {
                    Console.WriteLine("Médio");
                }
                else if(urgencia <= 9)
                {
                    Console.WriteLine("Alto");
                }
                else
                {
                    Console.WriteLine("Grave");
                }
            }
        }
    }
}