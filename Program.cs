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

namespace C_Para_Iniciantes
{
    class Program
    {

        static void MostrarSaborPizza(string[] pizzas)
        {
            foreach (string pizza in pizzas)
            {
                Console.WriteLine($"Temos sabor: {pizza} | Aproveite a refeição");
            }
        }
        static void Main(String[] angs)
        {
           string[] pizzas = {
            "Portuguêsa",
            "Bauru", 
            "Frango com Catupiry", 
            "4 Queijos",
            "Picanha",
            "Sensação",
            "Calabresa",
            "Atile",
            "Peperoni",
            "Atum"};

            MostrarSaborPizza(pizzas);
        } 
    }
}