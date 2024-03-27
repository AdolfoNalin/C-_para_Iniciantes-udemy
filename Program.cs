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
        public double AreaTriangulo(double lado1, double lado2)
        {
            double result = lado1 * lado2;
            double area = result / 2;
            return area;
        }

        static void Main(String[] angs)
        {
            Program pg = new Program();
            double area = pg.AreaTriangulo(250,350);
            Console.WriteLine(area); 
        }
    }
}