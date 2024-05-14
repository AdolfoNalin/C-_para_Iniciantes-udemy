using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_para_Iniciantesudemy;
using C_para_Iniciantesudemy.Objects.Formas;

namespace C_para_Iniciantesudemy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Drawble shape = new Line();

            shape.Draw();
        }
    }
}