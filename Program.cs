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
      //StreamWriter escritor = new StreamWriter("teste.txt"); => Para ecrever arquivos novos
      StreamWriter escritor = File.AppendText("teste.txt"); // Para editar arquivos que já existe e manter os dados
      
      escritor.WriteLine("Udemy");
      escritor.Close();

      Console.WriteLine("Arquivo salvo e criado");
    }
  }
}