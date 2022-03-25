using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaLeitura2._0.ConsoleApp
{
    internal class Menu
    {
        public static Amigo[] amigos = new Amigo[100];
        public static Caixa[] caixas = new Caixa[100];
        public static Revista[] revistas = new Revista[100];
        public static Emprestimo[] emprestimos = new Emprestimo[100];
        public static void MenuPrincipal()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" \n                         Clube Da Leitura ");
                Console.WriteLine("____________________________________________________________\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Amigos \n2.Revistas \n3.Caixas \n4.Empréstimos \n5.Reservas \n6.Sair\n");
                Console.WriteLine("____________________________________________________________\n\n");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuAmigo();
                        break;
                    case "2":
                        MenuRevista();
                        break;
                    case "3":
                        MenuCaixa();
                        break;
                    case "4":
                        MenuEmprestimo();
                        break;
                    case "5":
                        MenuReservas();
                        break;

                }
            } while (opcao != "6");

        }
        public static void MenuAmigo()
        {
            String opcaoAmigo;
            do
            {
                Console.Clear();
                Console.WriteLine(" \n                         Amigos ");
                Console.WriteLine("____________________________________________________________\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Cadastrar amigo \n2.Visualizar Lista Amigos \n3.Editar \n4.Excluir \n5.Voltar");
                Console.WriteLine("____________________________________________________________\n\n");
                opcaoAmigo = Console.ReadLine();

                switch (opcaoAmigo)
                {
                    case "1":
                        Amigo amigo = new Amigo();
                        Amigo.CadastrarAmigo(amigos, amigo);
                        break;
                    case "2":
                        Amigo.ListaAmigo(amigos);
                        break;
                    case "3":
                        Amigo.EditarAmigo(amigos);
                        break;
                    case "4":
                        Amigo.ExcluirAmigo(amigos);
                        break;
                }
                if (opcaoAmigo == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                }
            }
            while (opcaoAmigo != "6");

        }
        public static void MenuRevista()
        {
            String opcaoRevista;
            do
            {
                Console.Clear();
                Console.WriteLine(" \n                         Revistas ");
                Console.WriteLine("____________________________________________________________\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Cadastrar revista \n2.Visualizar todas as revistas \n3.Editar revista \n4.Excluir revista \n5.Voltar");
                Console.WriteLine("____________________________________________________________\n");
                opcaoRevista = Console.ReadLine();

                switch (opcaoRevista)
                {
                    case "1":
                        Revista revista = new Revista();
                        Revista.CadastrarRevista(revistas, revista, caixas);
                        break;
                    case "2":
                        Revista.ListaRevista(revistas);
                        break;
                    case "3":
                        Revista.EditarRevista(revistas);
                        break;
                    case "4":
                        Revista.ExcluirRevista(revistas);
                        break;
                }

                if (opcaoRevista == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                }
            }
            while (opcaoRevista != "4");
        }
        public static void MenuCaixa()
        {
            String opcaoCaixa;
            do
            {
                Console.Clear();
                Console.WriteLine(" \n                         Caixas ");
                Console.WriteLine("____________________________________________________________\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Cadastrar caixa \n2.Visualizar todas as caixas \n3.Editar caixa \n4.Excluir \n5.Voltar");
                Console.WriteLine("____________________________________________________________\n");
                opcaoCaixa = Console.ReadLine();

                switch (opcaoCaixa)
                {
                    case "1":
                        Caixa caixa = new Caixa();
                        Caixa.CadastrarCaixa(caixas, caixa);
                        break;
                    case "2":
                        Caixa.Lista(caixas);
                        break;
                    case "3":
                        Caixa.EditarCaixa(caixas);
                        break;
                    case "4":
                        Caixa.ExcluirCaixa(caixas);
                        break;
                }

                if (opcaoCaixa == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                }
            }
            while (opcaoCaixa != "4");
        }
        public static void MenuEmprestimo()
        {
            String opcaoEmprestimo;
            do
            {
                Console.Clear();
                Console.WriteLine(" \n                         Empréstimos ");
                Console.WriteLine("____________________________________________________________\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Cadastrar empréstimo \n2.Visualizar empréstimo \n3.Editar empréstimo \n4.Excluir \n5.Voltar");
                Console.WriteLine("____________________________________________________________\n");
                opcaoEmprestimo = Console.ReadLine();

                switch (opcaoEmprestimo)
                {
                    case "1":
                        Emprestimo emprestimo = new Emprestimo();
                        Emprestimo.CadastrarEmprestimo(emprestimos, emprestimo, amigos, revistas);
                        break;
                    case "2":
                        Emprestimo.ListaEmprestimo(emprestimos, amigos, revistas);
                        break;
                    case "3":
                        Emprestimo.EditarEmprestimo(emprestimos, amigos, revistas);
                        break;
                    case "4":
                        Emprestimo.ExcluirEmprestimo(emprestimos, amigos, revistas);
                        break;
                }

                if (opcaoEmprestimo == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                }
            }
            while (opcaoEmprestimo != "4");
        }

        public static void MenuReservas()
        {
            String opcaoReservas;
            do
            {
                Console.Clear();
                Console.WriteLine(" \n                         Reservas ");
                Console.WriteLine("____________________________________________________________\n");
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine("\n1.Cadastrar reserva \n2.Visualizar reserva \n3.Editar reserva \n4.Excluir \n5.Voltar");
                Console.WriteLine("____________________________________________________________\n");
                opcaoReservas = Console.ReadLine();

                switch (opcaoReservas)
                {
                    case "1":
                        Reserva reserva = new Reserva();
                        Reserva.CadastrarReserva();
                        break;
                    case "2":
                        Reserva.ListarReservas();
                        break;
                    case "3":
                        Reserva.Editar();
                        break;
                    case "4":
                        Reserva.ExcluirReserva();
                        break;
                }

                if (opcaoReservas == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar");
                    Console.ReadLine();
                    break;
                }
            }
            while (opcaoReservas != "4");

        }
}
}
