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
            string cor = "Azul";
            
            switch (cor)
            {
                case "VErmelhor":
                    Console.WriteLine("Sua cor favorita é vermelhor");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarela");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                case "Rosa":
                    Console.WriteLine("Sua cor favorita é Rosa");
                    break;
                default: 
                    Console.WriteLine("Essa cor não é valida");
                    break;
            }
        }
    }
}