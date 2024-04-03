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
      List<string> clientes = new List<string>();

      clientes.Add("Adolfo");
      clientes.Add("Renam");
      clientes.Add("Otávio");
      clientes.Add("Adolfo Nalin Junior");
      clientes.Add("Josemar");
      clientes.Add("Rafaela");
      clientes.Add("Ana júlia");


      // foreach(string cliente in clientes)
      // {
      //   Console.WriteLine(cliente);
      // }
      
      string FindBuscar = clientes.Find(cliente => cliente == "Josemar");
      string FindMais10 = clientes.Find(cliente => cliente.Length > 10); // Retorna o primeiro resultado
      List<string> FindAllMais5 = clientes.FindAll(cliente => cliente.Length > 5); // Retorna o primeiro resultado

      Console.WriteLine(FindBuscar);
      Console.WriteLine(FindMais10);

      Console.WriteLine("==========================================================");

      foreach (string item in FindAllMais5)
      {
        Console.WriteLine(item);
      }      
    }
  }
}