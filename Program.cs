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
            int time = 7;

            while(time >= 7 && time <= 17)
            {
                Console.WriteLine($"São {time} e o mercado está aberto!.");
                time++;
            }
            Console.WriteLine("Infelzimente nosso horário de funcionamento é das 7hrs até 17hrs");
        } 
    }
}