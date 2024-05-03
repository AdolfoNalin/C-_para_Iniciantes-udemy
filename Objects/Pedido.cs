using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__ParaIniciantes
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Mesa { get; set; }
        public List<string> Pratos = new List<string>();
        public List<string> Bebedas = new List<string>();
        public float Total { get; set; }
    }
}