using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Para_Iniciantes
{
    class Program
    {
        static void Main(String[] angs)
        {
            // int Armazena valores interios positivois ou negativos
            // float Armazena valores de ponto flutuante
            // Double Armazena valores de pronto flutuante
            // bool True or char
            // Sting Armazena texto  "Adolfo"
            // char Armazena Caracteres

            // Criando Variáveis
            int anoSegundaGerraMundial = 1942;
            string cor_favorita = "Preto";
            float velocidadeF1 = 294.48f; 
            bool SegundaGerraMundialAconteceu = true;

            // Mostrando Variáveis
            Console.WriteLine(anoSegundaGerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(SegundaGerraMundialAconteceu);

            // Alterando variaveis
            velocidadeF1 = 348.29f;
            cor_favorita += "\nAzul";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_favorita);
        }
    }
}