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
        static string MensagemBoasVindas(string nome)
        {
            return $"Seja bem-vindo {nome} a nossa escola!";
        }
        static void Main(String[] angs)
        {
            string[] alunos = {"Giovana", "Jessica", "Rafaela", "Julia", "Ana Claudia", "Claudia", "Marine", "Sophia", "Ana Julia"};

            for(int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine(MensagemBoasVindas(alunos[i]));
            }
        } 
    }
}