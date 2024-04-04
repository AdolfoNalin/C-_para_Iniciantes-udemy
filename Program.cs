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
using System.Reflection;

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
      List<string> lg = new List<string>();
      lg.Add("C#");
      lg.Add("Javascript");
      lg.Add("PHP");

      Produtos prod = new Produtos();
      prod.nome = "banana";
      prod.preco = 2.40f;
      FileStream fs = new FileStream("meuarquivo.pdf",FileMode.OpenOrCreate);
      BinaryFormatter encoder = new BinaryFormatter();

/*
#pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
      encoder.Serialize(fs, lg);
      encoder.Serialize(fs, prod);
#pragma warning restore SYSLIB0011
*/

#pragma warning disable SYSLIB0011
      List<string> read = (List<string>)encoder.Deserialize(fs);
      Produtos pd = (Produtos)encoder.Deserialize(fs);
#pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto

        fs.Close();

        Console.WriteLine(read[0]);
        Console.WriteLine(pd.nome);

    }
  }
}