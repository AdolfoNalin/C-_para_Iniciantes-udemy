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

        static int Menu()
        {
            Console.WriteLine("Selecione uma das Opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listrar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            return index;
        }

        enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar};
        static void Main(String[] angs)
        {
            
            Opcao selectOp = (Opcao) Menu();

            switch(selectOp)
            {
                case Opcao.Criar:
                    Console.WriteLine("O que você deseja Criar?");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("O que você deseja elimina?");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("O que você deseja Editar?");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("O que você deseja Listar?");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("O que você deseja Atualizar?");
                    break;
                default:
                    Console.WriteLine("Essa opção não existe! verifique o menu novamente!");
                    selectOp = (Opcao) Menu();
                    break;
            }
        } 
    }
}