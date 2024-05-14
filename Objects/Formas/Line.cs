using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_para_Iniciantesudemy;

namespace C_para_Iniciantesudemy.Objects.Formas
{
    public class Line : Drawble
    {
        public override void Draw()
        {
            Console.WriteLine("- Linha -");
        }

        public override float Area()
        {
            return 0;
        }
    }
}