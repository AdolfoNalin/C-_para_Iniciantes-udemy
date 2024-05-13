using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_para_Iniciantesudemy;

namespace C_para_Iniciantesudemy.Objects.Formas
{
    public class Line : Idrawable
    {
        public void Draw()
        {
            Console.WriteLine("- Linha -");
        }

        public float Area()
        {
            return 0;
        }

        public float Color()
        {
            throw new NotImplementedException();
        }
    }
}