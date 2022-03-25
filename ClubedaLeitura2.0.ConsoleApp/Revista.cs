using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaLeitura2._0.ConsoleApp
{
    internal class Revista
    {
        public String tipoColecao;
        public String numeroEdicao;
        public DateTime anoEdicao;
        public int IdCaixa;
        public Revista[] revistasNaCaixa = new Revista[100];

        public static void CadastrarRevista(Revista[] revistas, Revista newRevista, Caixa[] caixas) // OBS CAIXA
        {
            Console.Clear();
            Console.Write("Insira a coleção: ");
            newRevista.tipoColecao = Console.ReadLine();

            Console.Write("Insira o número de edição: ");
            newRevista.numeroEdicao = Console.ReadLine();

            Console.Write("Insira o ano da revista: ");
            newRevista.anoEdicao = DateTime.Parse(Console.ReadLine());

            Caixa.Lista(caixas);
            Console.Write("Insira o id da caixa onde está guardada a revista: ");
            int IdCaixa = int.Parse(Console.ReadLine());

        }
        public static void VisualizarRevistas(Revista[] revistas)
        {
            Console.Clear();
            for (int i = 0; i < revistas.Length; i++)
            {
                if (revistas[i] != null)
                {
                    Console.WriteLine("\nTipo de coleção: " + revistas[i].tipoColecao);
                    Console.WriteLine("\nNúmero da Edição: " + revistas[i].numeroEdicao);
                    Console.WriteLine("\nAno da revista: " + revistas[i].anoEdicao);
                    Console.WriteLine("\nID da revista: " + i);
                }
            }
        }
        public static void EditarRevista(Revista[] revistas)
        {
            Console.Clear();
            VisualizarRevistas(revistas);

            Console.Write("\nInsira o id da revista que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("\nInsira o novo tipo de coleção: ");
            revistas[id].tipoColecao = Console.ReadLine();

            Console.Write("\nInsira o novo número da edição: ");
            revistas[id].numeroEdicao = (Console.ReadLine());

            Console.Write("\nInsira a novo data de fabricação: ");
            revistas[id].anoEdicao = DateTime.Parse(Console.ReadLine());

            Console.Write("O ID da caixa em que a revista se encontra: ");
            revistas[id].IdCaixa = int.Parse(Console.ReadLine());

            Console.WriteLine("Revista editada com sucesso!");
        }
        public static void ExcluirRevista(Revista[] revistas) //remover e devolver pra caixa
        {
            Console.Clear();
            VisualizarRevistas(revistas);
            Console.Write("Digite o id da revista para excluir: ");
            int id = int.Parse(Console.ReadLine());

            revistas[id] = null;

            Console.WriteLine("Revista excluída com sucesso!");

        }
        public static void ListaRevista(Revista[] revistas)
        {
            Console.Clear();
            VisualizarRevistas(revistas);
            Console.ReadKey();
        }
}
}
