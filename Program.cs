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
using System.Runtime.Serialization.Formatters.Binary;

namespace C_Para_Iniciantes
{
  class Program 
  {
    [Serializable]
    struct Produtos
    {
      public string nome;
      public float preco;
    }

    static void Main(String[] angs)
    {
      FileStream fs = new  FileStream("meuarquivo.pdf", FileMode.OpenOrCreate);
      BinaryFormatter encoder = new BinaryFormatter();

//       int i = 120;
// #pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
//             encoder.Serialize(fs, i);
//             encoder.Serialize(fs, "Adolfo");
//             encoder.Serialize(fs, true);
// #pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto

//           fs.Close();

//           Console.WriteLine("Arquivo foi salvo");

//       List<string> lg = new List<string>();

//       lg.Add("C#");
//       lg.Add("Java");
//       lg.Add("Javascript");
//       lg.Add("HTMl");

// #pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
//             encoder.Serialize(fs, lg);
// #pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto


      Produtos banana = new Produtos();
      banana.nome = "Banana";
      banana.preco = 2.50f;

      Produtos maca = new Produtos();
      maca.nome = "maça";
      maca.preco = 3.20f;
    
      #pragma warning disable SYSLIB0011
      encoder.Serialize(fs, banana);
      #pragma warning restore SYSLIB0011
      Console.WriteLine(" O arquivo foi salvo!");
    }
  }
}