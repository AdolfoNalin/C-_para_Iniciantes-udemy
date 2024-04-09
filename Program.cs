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
using System.Security.Cryptography;

namespace C_Para_Iniciantes
{
  // Exemplo de classificação
  class Game
  {
    #region Atributos ou Campos
    public string titulo;
    public string genero;
    public string produtora;
    public float preco;
    #endregion

    #region Metodos
    public void Abrir()
    {
      Console.WriteLine("Abrindo...");
    }

    public void Carregando()
    {
      Console.WriteLine("Carregando...");
    }
  
    public void Executar()
    {
      Console.WriteLine("Executando...");
    }

    public void Fechar()
    {
      Console.WriteLine("Fechando...");
    }
    #endregion
  }
  class Program 
  {
    static void Main(String[] angs)
    {
      // Invocando a classe
      Game CS = new Game();
      CS.titulo = "Conter Strick 2";
      CS.genero = "Ação";
      CS.produtora = "Valve";
      CS.preco = 30.00f;

      CS.Abrir();
      CS.Carregando();
      CS.Executar();
      CS.Fechar();
    }
  }
}