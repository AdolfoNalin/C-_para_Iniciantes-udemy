using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_para_Iniciantesudemy.Objects.Heranças;

namespace C_para_Iniciantesudemy.Objects.Heranças
{
    public class Zelador : Usuario
    {
        List<string> task = new List<string>();

        public Zelador(string nome, string email, string password) : base(nome, email, password)   
        {
            
        }

        public void SetTask(List<string> task)
        {
            for(int i = 0; i < task.Count; i++)
            {
                this.task.Add(task[i]);
            }
        }

        public override void GetInformation()
        {
            Console.WriteLine("Dados do Zelador");
            base.GetInformation();

            for(int i = 0; i < task.Count; i++)
            {
                Console.WriteLine(task[i]);
            }
        }
    }
}