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
      enum menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair};

      static void Soma()
      {
        Console.WriteLine("A soma de 2 números!");
        Console.WriteLine("Digite o primeiro número");
        double num1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        double num2 = Double.Parse(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"A soma dos Dois números é: {result}");
        Console.WriteLine("Aperte ENTER para voltar para o menu!");
      }

      static void Subtracao()
      {
        Console.WriteLine("A subtração de 2 números!");
        Console.WriteLine("Digite o primeiro número");
        double num1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        double num2 = Double.Parse(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"A subtração de Dois números é: {result}");
        Console.WriteLine("Aperte ENTER para voltar para o menu!");
      }

      static void Divisao()
      {
        Console.WriteLine("A divisão de 2 números!");
        Console.WriteLine("Digite o primeiro número");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        float num2 = float.Parse(Console.ReadLine());

        float result = num1 / num2;
        Console.WriteLine($"A divisão dos Dois números é: {result}");
        Console.WriteLine("Aperte ENTER para voltar para o menu!");
      }

      static void Multiplicacao()
      {
        Console.WriteLine("A multiplicação de 2 números!");
        Console.WriteLine("Digite o primeiro número");
        double num1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        double num2 = Double.Parse(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"A multiplicação dos Dois números é: {result}");
        Console.WriteLine("Aperte ENTER para voltar para o menu!");
      }

      static void Potencia()
      {
        Console.WriteLine("A Potência de 1 números!");
        Console.WriteLine("Digite a base");
        double baseNum = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        double expo = Double.Parse(Console.ReadLine());

        double result = Math.Pow(baseNum,expo);
        Console.WriteLine($"A Potência dos Dois números é: {result}");
        Console.WriteLine("Aperte ENTER para voltar para o menu!");
      }

      static void Raiz()
      {
        Console.WriteLine("A raiz de 1!");
        Console.WriteLine("Digite o número");
        double num = Double.Parse(Console.ReadLine());

        double result = Math.Sqrt(num);
        Console.WriteLine($"A raiz é: {result}");
        Console.WriteLine("Aperte ENTER para voltar para o menu!");
      }
      
      static int Menu()
      {
        try
        {
          Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opçõs");
          Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
          int opcao = int.Parse(Console.ReadLine());

          return opcao;
        }
        catch (Exception ex)
        {
          Console.WriteLine("Digite um número correspontente");
          Menu();
          throw;
        }
        
    }

      static void Main(String[] angs)
      {
        bool sair = false;
        while(!sair)
        {
          
          menu opcao = (menu) Menu();

          switch (opcao)
          {
            case menu.Soma:
              Soma();
              break;
            case menu.Subtracao:
              Subtracao();
              break;
            case menu.Divisao:
              Divisao();
              break;
            case menu.Multiplicacao:
              Multiplicacao();
              break;
            case menu.Potencia:
              Potencia();
              break;
            case menu.Raiz:
              Raiz();
              break;
            case menu.Sair:
              sair = true;
              break;
              default:
              opcao = (menu) Menu();
          }
        }
      
        Console.ReadKey();
        Console.Clear();
      } 
    }
}