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
using System.IO;

namespace C_Para_Iniciantes
{
  class Program 
  {
    static void Main(String[] angs)
    {
      /*StreamWriter escritor = new StreamWriter("teste.txt"); => Para ecrever arquivos novos
      StreamWriter escritor = File.AppendText("teste.txt"); => Para editar arquivos que já existe e manter os dados
      
      escritor.WriteLine("Udemy");
      escritor.Close();
      */

      StreamReader sr = new StreamReader("teste.txt");
      // string cont = sr.ReadToEnd(); // Conteudo do arquivo todo em uma string

      // Console.WriteLine(cont);

      /* Lendo linha por linha de um documento texto
      string line = "";
      while(line != null)
      {
        line = sr.ReadLine();
        if(line != null)
        {
          Console.WriteLine(line);
        }
      }
      sr.Close();*/

      /* Passando os valor de um documento texto para uma array
      Console.WriteLine("------------------------------------------------");
      string textLine = "";
      List<string> lines = new List<string>();
      while(textLine != null)
      {
        textLine = sr.ReadLine();
        if(textLine != null)
        {
          lines.Add(textLine);
        }
      }

      sr.Close();

      
      foreach(string linha in lines)
      {
        Console.WriteLine(linha);
      }*/

      // Tentando criar um outro tipo de leitura
      // foreach (char script in sr.ReadLine())
      // {
      //   string linha = "";
      //   linha = script;

      //   if(linha != null)
      //   {
      //     Console.WriteLine(script);
      //   }
      //   else if(linha.Count() + 1 == null)
      //   {
      //     sr.Close();
      //     break;
      //   }
      // }

      Console.WriteLine("Arquivo salvo e criado");
    }
  }
}