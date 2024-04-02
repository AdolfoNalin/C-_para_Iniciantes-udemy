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


      foreach(string cliente in clientes)
      {
        Console.WriteLine(cliente);
      }
      
      Console.WriteLine("==========================================");
      clientes.RemoveAt(1); //Remove pelo indix
      clientes.RemoveAll((cliente) => cliente == "Adolfo"); //Remove pelo nome
      clientes.Remove("Otávio"); // Remove o nome
      clientes.RemoveRange(1,3); //Remove de um ponto a outro

      foreach(string cliente in clientes)
      {
        Console.WriteLine(cliente);
      }
    }
  }
}