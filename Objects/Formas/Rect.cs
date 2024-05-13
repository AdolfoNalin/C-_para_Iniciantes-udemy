using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_para_Iniciantesudemy.Objects.Formas
{
    public class Rect : Idrawable
    {
        public void Draw()
        {
            Console.WriteLine("- Rect -");
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