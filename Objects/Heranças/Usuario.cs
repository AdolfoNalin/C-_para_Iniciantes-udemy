using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_para_Iniciantesudemy.Objects.Heranças
{
    public class Usuario
    {
        protected string name;
        protected string email;
        protected string password;
        protected string teste;

        public Usuario(string nome, string email, string password)
        {
            name = nome;
            this.email = email;
            this.password = password;
        }

        public void Login()
        {
            Console.WriteLine("Logando");
        }    

        public void Login(string nome, string senha)
        {
            Console.WriteLine("Logando com o nome e senha...");
        }

        public void Login(string  codigo)
        {
            Console.WriteLine("Logando com o código...");
        }

        public void  Login (int pin, string email)
        {
            Console.WriteLine ("Logando com o pin e email");
        }

        public void GetInformation()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Password: {password}");
        }
    }
}