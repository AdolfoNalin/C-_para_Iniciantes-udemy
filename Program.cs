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
        enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar};
        static void Main(String[] angs)
        {
            Console.WriteLine("Selecione uma das Opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listrar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());

            Opcao selectOp = (Opcao) index;

            switch(selectOp)
            {
                case Opcao.Criar:
                    Console.WriteLine();
                    break;
                case Opcao.Deletar:
                    Console.WriteLine();
                    break;
                case Opcao.Editar:
                    Console.WriteLine();
                    break;
                case Opcao.Listar:
                    Console.WriteLine();
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Essa opção não existe! verifique o menu novamente!");
                    break;
            }
        } 
    }
}