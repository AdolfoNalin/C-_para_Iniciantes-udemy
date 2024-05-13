using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_para_Iniciantesudemy.Objects.Formas
{
    public class Quad : Idrawable
    {
        public float Area()
        {
            return 0;
        }

        public float Color()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            Console.WriteLine("- Quadrador -");
        }
    }
}