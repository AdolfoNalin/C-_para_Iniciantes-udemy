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
  class Program 
  {
    static List<Cliente> listClient = new List<Cliente>();

    #region Menu
    enum Menu {Listagem = 1, Adicionar, Remover, Sair}
    #endregion

    #region Cliente
    [Serializable]
    struct Cliente
    {
      public string Nome { get; set; }
      public string CPF { get; set; }
      public string Email { get; set; }
    }
    #endregion

    #region Metodo Add
    static void Add()
    {
      Cliente obj = new Cliente();
      Console.WriteLine("Cadastro de Cleintes");
      Console.WriteLine("Nome do Cliente: ");
      obj.Nome = Console.ReadLine();

      Console.WriteLine("Email do Cliente:");
      obj.Email = Console.ReadLine();

      Console.WriteLine("CPF do Cliente");
      obj.Email = Console.ReadLine();

      listClient.Add(obj);
      Cadastar(listClient);

      Console.WriteLine("Cadastro concluido!");
      Console.WriteLine("Aperte enter para sair");
      Console.ReadKey();
    }
    #endregion

    #region Metodo Listar
    static void Listar()
    {
      if(listClient.Count > 0)
      {
        Console.WriteLine("Listar Cliente");
        for(int i = 0; i < listClient.Count; i++)
        {
          Console.WriteLine($"ID: {i} | Nome: {listClient[i].Nome} | CPF: {listClient[i].CPF} | Email: {listClient[i].Email}");
          Console.WriteLine("_______________________________________________________________________________________________");
        }

        Console.WriteLine("Aperte enter para sair!");
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine("Adicione clientes a lista, para conseguimos listar! Aperte enter para sair");
        Console.ReadKey();
      }
     
    }
    #endregion

    #region Cadastrar
    static void Cadastar(List<Cliente> list)
    {
      FileStream fs = new FileStream("bdClientes.txt", FileMode.OpenOrCreate);
      BinaryFormatter bf = new BinaryFormatter();

      #pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
      bf.Serialize(fs,list);
      #pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto

      fs.Close();
    }
    #endregion

    #region Carregar Clientes
    static void Carregar()
    {
      FileStream fs = new FileStream("bdClientes.txt", FileMode.OpenOrCreate);

      try
      {
        BinaryFormatter bf = new BinaryFormatter();

        #pragma warning disable SYSLIB0011 // O tipo ou membro é obsoleto
        listClient = (List<Cliente>) bf.Deserialize(fs);
        #pragma warning restore SYSLIB0011 // O tipo ou membro é obsoleto

        if(listClient == null)
        {
          listClient = new List<Cliente>();
        }

      }
      catch (Exception ex)
      {
        listClient = new List<Cliente>();
      }
      finally
      {
        fs.Close();
      }
     
    }
    #endregion
    
    #region Remover
    static void Remover()
    {
      Listar();
      Console.WriteLine("Digite o ID do cliente que você deseja remover!");
      int id = int.Parse(Console.ReadLine());
      
      id = Math.Abs(id);

      if(id >= 0 && id < listClient.Count)
      {
        listClient.RemoveAt(id);
        Cadastar(listClient);
      }
      else
      {
        Console.WriteLine($"O Id {id} digitado é menor ou maior que a lista, por favor verifique o valor correto!");
        Console.ReadKey();
      }
    
    }
    #endregion
    static void Main(String[] angs)
    {
      Carregar();
      bool sair = false;
      while(!sair)
      {
        Console.WriteLine($"Sitema de Clientes - bem vindos");
        Console.WriteLine($"1-{Menu.Listagem}\n2-{Menu.Adicionar}\n3-{Menu.Remover}\n4-{Menu.Sair}");
        int op = int.Parse(Console.ReadLine());

        Menu opcao = (Menu) op;
        Console.WriteLine(opcao);

        switch (opcao)
        {
          case Menu.Listagem:
            Listar();
            break;
          case Menu.Adicionar:
            Add();
            break;
          case Menu.Remover:
            Remover();
            break;
          case Menu.Sair:
            sair = true;
            break;
          default:
            break;
        }
        Console.Clear();
      }
    }
  }
}