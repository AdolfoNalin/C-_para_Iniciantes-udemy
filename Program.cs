using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Para_Iniciantes
{
    class Program
    {
        static void Main(String[] angs)
        {
            // Forma Priguiçosa
            var cor_favorito = "Preto";
            var modeloDeProduto = 022983934;

            // Forma Dinamica, pode mudar o tipo, isso varia do valor que está sendo armazenado
            dynamic nome = "Adofo nalim";
            Console.WriteLine(nome);
            nome = 3000.0f;
            Console.WriteLine(nome);
        }
    }
}