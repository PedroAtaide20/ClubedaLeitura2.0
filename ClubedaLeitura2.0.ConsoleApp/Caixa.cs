using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubedaLeitura2._0.ConsoleApp
{
    internal class Caixa
    {
        public String cor;
        public String etiqueta;
        public int numeroCaixa;
        public Revista[] revistasNaCaixa = new Revista[100];
        public int id = 0;

        public static void CadastrarCaixa(Caixa[] caixas, Caixa newCaixa)
        {
            Console.Clear();
            Console.Write("Insira a cor: ");
            newCaixa.cor = Console.ReadLine();

            Console.Write("Insira a etiqueta: ");
            newCaixa.etiqueta = Console.ReadLine();

            Console.Write("Insira o número da caixa ");
            newCaixa.numeroCaixa = int.Parse(Console.ReadLine());

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] == null)
                {
                    caixas[i] = newCaixa;
                    break;
                }
            }

        }
        public static void VisualizarCaixas(Caixa[] caixas)
        {
            Console.Clear();
            int id = 0;

            for (int i = 0; i < caixas.Length; i++)
            {
                if (caixas[i] != null)
                {
                    Console.WriteLine("\nId da caixa: " + i);
                    Console.WriteLine("\nCor da caixa: " + caixas[i].cor);
                    Console.WriteLine("\nEtiqueta da caixa: " + caixas[i].etiqueta);
                    Console.WriteLine("\nNúmero da caixa: " + caixas[i].numeroCaixa);
                }
            }
        }
        public static void Lista(Caixa[] caixas)
        {
            VisualizarCaixas(caixas);
            Console.ReadKey();
        }
        public static void EditarCaixa(Caixa[] caixas)
        {
            Console.Clear();
            VisualizarCaixas(caixas);

            Console.WriteLine("\nInsira o id da caixa que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira a nova cor da caixa: ");
            caixas[id].cor = Console.ReadLine();

            Console.WriteLine("\nInsira a nova etiqueta da caixa: ");
            caixas[id].etiqueta = Console.ReadLine();

            Console.WriteLine("\nInsira o novo número da caixa: ");
            caixas[id].numeroCaixa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Caixa editada com sucesso!");
        }
        public static void ExcluirCaixa(Caixa[] caixas)
        {
            Console.Clear();
            VisualizarCaixas(caixas);
            Console.WriteLine("Digite o id da caixa para excluir: ");
            int id = int.Parse(Console.ReadLine());

            caixas[id] = null;
            Console.WriteLine("Caixa Excluída com sucesso!");
        }
        public static void AddRevistaNaCaixa(Caixa[] caixas, int IdCaixa, Revista revista, Revista[] revistasEmprestadas) //OBSERVAÇÃO
        {
            for (int i = 0; i < caixas[IdCaixa].revistasNaCaixa.Length; i++)
            {
                if (caixas[IdCaixa].revistasNaCaixa[i] == null)
                {
                    caixas[IdCaixa].revistasNaCaixa[i] = revista;
                    break;
                }
}
}
}
}

