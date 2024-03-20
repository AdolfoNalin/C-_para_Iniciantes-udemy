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

        public void PrecoFinal(string nome, decimal valorInicial)
        {
            decimal valorFinal = valorInicial;
            valorFinal += (25 * valorInicial) / 100;
            
            Console.WriteLine($"{nome} Valor R${valorFinal}");
        }

        static void Main(String[] angs)
        {
            Program program = new Program();
            program.PrecoFinal("Chocolate", 30);
            program.PrecoFinal("Refrigerante", 50);
            program.PrecoFinal("Bolo", 45);
            program.PrecoFinal("Sorvete", 60);
            program.PrecoFinal("Pão", 15);
        }
    }
}