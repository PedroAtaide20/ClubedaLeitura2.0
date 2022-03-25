using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaLeitura2._0.ConsoleApp
{
    internal class Amigo
    {
        public String nome;
        public String nomeDoResponsavel;
        public String telefone;
        public String endereco;
        public bool temEmprestimo = false;

        public static void CadastrarAmigo(Amigo[] amigos, Amigo newAmiguinho)
        {
            Console.Clear();
            Console.Write("Insira o nome: ");
            newAmiguinho.nome = Console.ReadLine();

            Console.Write("Insira o nome do responsável: ");
            newAmiguinho.nomeDoResponsavel = Console.ReadLine();

            Console.Write("Insira o telefone: ");
            newAmiguinho.telefone = Console.ReadLine();

            Console.Write("Insira o endereço: ");
            newAmiguinho.endereco = Console.ReadLine();

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                {
                    amigos[i] = newAmiguinho;
                    break;
                }
            }
        }
        public static void VisualizarAmigo(Amigo[] amigos)
        {

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                {
                    Console.WriteLine("Id do amigo: " + i);
                    Console.WriteLine("Nome do amigo: " + amigos[i].nome);
                    Console.WriteLine("Nome do responsável: " + amigos[i].nomeDoResponsavel);
                    Console.WriteLine("Telefone do amigo: " + amigos[i].telefone);
                    Console.WriteLine("Endereço do amigo: " + amigos[i].endereco);
                    Console.WriteLine("Possui empréstimo: " + amigos[i].temEmprestimo);

                }
                else
                {
                    return;
                }
            }
            Console.ReadKey();
        }
        public static void EditarAmigo(Amigo[] amigos) //só pode editar o telefone e o endereço.
        {
            Console.Clear();
            VisualizarAmigo(amigos);

            Console.Write("\nInsira o id do amigo que deseja editar: ");
            int id = int.Parse((Console.ReadLine()));

            Console.Write("\nInsira o nome do amigo: ");
            amigos[id].nome = Console.ReadLine();

            Console.Write("\nInsira o nome do responsável: ");
            amigos[id].nomeDoResponsavel = Console.ReadLine();

            Console.Write("\nInsira o novo telefone do amigo: ");
            amigos[id].telefone = Console.ReadLine();

            Console.Write("\nInsira o novo endereço do amigo: ");
            amigos[id].endereco = Console.ReadLine();

        }
        public static void ExcluirAmigo(Amigo[] amigos)
        {
            Console.Clear();
            VisualizarAmigo(amigos);
            Console.WriteLine();
            Console.WriteLine("Digite o id do amigo para excluir: ");
            int id = int.Parse(Console.ReadLine());

            Console.Clear();

        }
        public static void ListaAmigo(Amigo[] amigos)
        {
            Console.Clear();
            VisualizarAmigo(amigos);
            Console.ReadKey();
        }
}
}
