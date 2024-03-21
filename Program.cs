using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using C_Para_Iniciantes;

namespace C_Para_Iniciantes
{
    class Program
    {
        public double Raio(double raio)
        {
            double cf = (raio * raio) * Math.PI;
            return cf;
        }

        static void Main(String[] angs)
        {
            Program pg = new Program();
            Console.WriteLine(pg.Raio(30));
        }
    }
}