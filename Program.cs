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
            GerarPreco(-10);
            int result = Soma(100,200,330);

            Console.WriteLine(result);
        }

        static void ExibirMSG()
        {
            Console.WriteLine("Esse sistema é Show de bola");
            Console.WriteLine("Estou usando funções");
        }

        static void GerarPreco(decimal valor)
        {
           if (valor < 0)
           {
                valor = Math.Abs(valor);
           }

           decimal valorFinal = valor + (2 * valor);
           Console.WriteLine("Valor final: " + valor);
        }

        static int Soma(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
    }
}