
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
using C__ParaIniciantes;

namespace C_Para_Iniciantes
{
  class Program 
  {
    static void Main (String[] angs)
    {
      // Os elementos static podem ser acessados direto da classe como:
      Filme.Pausar();

      // Porém não tem como usar a um método ou atributo static de um objeto
      
    }
  }
}