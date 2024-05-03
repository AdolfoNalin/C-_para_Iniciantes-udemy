using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_para_Iniciantesudemy.Objects.Heranças
{
    public class Usuario
    {
        public string name;
        public string email;
        public string password;

        public void Login(string nome, string senha)
        {
            Console.WriteLine("Logando...");
        }

        public void GetInformation()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Password: {password}");
        }
    }
}