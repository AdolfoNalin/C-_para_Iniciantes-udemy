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
    struct Produto
    {
     
      public string Nome;
      public float Preco;
      public float Peso;
      public string Marca;

      public Produto(string nome,float preco, float peso, string marca)
      {
        this.Nome = nome;
        this.Preco = preco;
        this.Peso = peso;
        this.Marca = marca;
      }
    }

    static void Main(String[] angs)
    {
      Produto bola = new Produto("Celular", 1500.00f, 0.700f, "Iphone");

      Console.WriteLine(bola.Nome);
    }
  }
}