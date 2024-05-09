using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_para_Iniciantesudemy.Objects.Heranças
{
    public class Aluno : Usuario
    {
        public string turno;

        public Aluno(string turno, string nome, string email, string password) : base(nome, email, password)
        {
            this.turno = turno;
        }

        public String MudTeste(){
            return teste;
        }
        
    }
}