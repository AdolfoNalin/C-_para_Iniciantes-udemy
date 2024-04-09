
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
    static void Main(String[] angs)
    {
      Filme MMF = new Filme();

      MMF.nome = "Meu Malvado Favorito";

      MMF.Executar();
    }
  }
}