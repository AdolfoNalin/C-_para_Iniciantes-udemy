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

      string nome = "Cleiton";
      clientes.Add(nome);

      Console.WriteLine(clientes[0]);
    }
  }
}