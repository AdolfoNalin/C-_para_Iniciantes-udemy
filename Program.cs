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
            string[] palavras = {"Vitor Lima", "Lima", "Guia do prog", "Formação", "Node", "Curso de C#", "Udemy!"};

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }
        } 
    }
}