using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_para_Iniciantesudemy.Objects.Formas
{
    public abstract class Drawble
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string Password { get; set; }

        // Elementos abstratos precisam ser encapsulados 
        public abstract void Draw();

        public virtual float Area()
        {
            return 0;
        }
    }
}