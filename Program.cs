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

      public float AddCupon(float porc)
      {
         float desconto = this.Preco * porc / 100f;
         return this.Preco - desconto;
      }

      public void ExibirInfo()
      {
        Console.WriteLine($"Nome: {this.Nome} \nPreço: R${this.Preco} \nPeso: {this.Peso} \nMarca: {this.Marca}");
      } 
    }

    static void Main(String[] angs)
    {
      Produto bola = new Produto("Celular", 1500.00f, 0.700f, "Iphone");

      bola.ExibirInfo();
      float valorFinal = bola.AddCupon(50f);

      Console.WriteLine($"Preço Final: R${valorFinal}");
    }
  }
}