using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaLeitura2._0.ConsoleApp
{
    internal class Emprestimo
    {
        public int idAmigo;
        public int idRevista;
        public DateTime dataEmprestimo;
        public DateTime dataDevolucao;
        public bool emprestimoAberto;

        public static void CadastrarEmprestimo(Emprestimo[] emprestimos, Emprestimo newEmprestimo, Amigo[] amigos, Revista[] revistas)
        {
            Console.Clear();

            Amigo.VisualizarAmigo(amigos);
            Console.WriteLine("Digite o id do amigo que deseja pegar um livro: ");
            newEmprestimo.idAmigo = int.Parse(Console.ReadLine());

            Revista.VisualizarRevistas(revistas);
            Console.WriteLine("Digite o id da revista que esse amigo deseja pegar:");
            newEmprestimo.idRevista = Convert.ToInt32(Console.ReadLine());

            newEmprestimo.emprestimoAberto = true;

            newEmprestimo.dataEmprestimo = DateTime.Today;

            Console.WriteLine("A data de devolução do livro é: " + (DateTime.Today.AddDays(7))); //7 dias da semana
            newEmprestimo.dataDevolucao = DateTime.Today.AddDays(7);

            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] == null)
                {
                    emprestimos[i] = newEmprestimo;
                    break;
                }
            }
        }
        public static void VisualizarEmprestimos(Emprestimo[] emprestimos, Amigo[] amigos, Revista[] revistas)
        {
            Console.Clear();
            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] != null)
                {
                    Console.WriteLine("\nId do empréstimo: " + i);
                    Console.WriteLine("\nData do empréstimo: " + emprestimos[i].dataEmprestimo);
                    Console.WriteLine("\nData de devolução: " + emprestimos[i].dataDevolucao);
                    Console.WriteLine("\nEmpréstimo em aberto: " + emprestimos[i].emprestimoAberto);
                }
                else
                {
                    return;
                }
            }
        }
        public static void EditarEmprestimo(Emprestimo[] emprestimos, Amigo[] amigos, Revista[] revistas)
        {
            Console.Clear();
            VisualizarEmprestimos(emprestimos, amigos, revistas);

            Console.WriteLine("\nInsira o id do empréstimo que deseja editar: ");
            int id = int.Parse((Console.ReadLine()));

            Console.Write("\nInsira o id do amigo que deseja pegar o livro: ");
            emprestimos[id].idAmigo = int.Parse(Console.ReadLine());

            Console.Write("\nInsira o id da revista que o amigo deseja pegar: ");
            emprestimos[id].idRevista = int.Parse(Console.ReadLine());
            emprestimos[id].emprestimoAberto = true; // foi emprestado

            Console.WriteLine("Número de dias adicionado na data limite: ");
            int numeroDias = int.Parse(Console.ReadLine());
            emprestimos[id].dataDevolucao = DateTime.Today.AddDays(7).AddDays(numeroDias);

        }
        public static void ExcluirEmprestimo(Emprestimo[] emprestimos, Amigo[] amigos, Revista[] revistas)
        {
            Console.Clear();
            VisualizarEmprestimos(emprestimos, amigos, revistas);
            Console.WriteLine("Digite o id do empréstimo para excluir: ");
            int id = int.Parse(Console.ReadLine());

            emprestimos[id] = null;
        }
        public static void ListaEmprestimo(Emprestimo[] emprestimos, Amigo[] amigos, Revista[] revistas)
        {
            Console.Clear();
            VisualizarEmprestimos(emprestimos, amigos, revistas);
            Console.ReadKey();
        }

        public static void VerificarSeRevistaDisponivel()
        {
        }
}
}
