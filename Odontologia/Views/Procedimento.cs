using System;
using Controllers;
using Models;

namespace Views
{
    public class ProcedimentoView
    {
        public static void InserirProcedimento()
        {
            Console.WriteLine("Digite a descrição: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do procedimento: ");
            double Preco = Convert.ToInt32(Console.ReadLine());

            ProcedimentoController.InserirProcedimento(
                Descricao,
                Preco
            );
        }

        public static void AlterarProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do Procedimento a ser alterado: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite a descrição: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço: ");
            double Preco = Convert.ToInt32(Console.ReadLine());

            ProcedimentoController.AlterarProcedimento(
                Id,
                Descricao,
                Preco
            );

        }

        public static void ExcluirProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            ProcedimentoController.ExcluirProcedimento(
                Id
            );

        }

        public static void ListarProcedimentos()
        {
            foreach (Procedimento item in ProcedimentoController.VisualizarProcedimentos())
            {
                Console.WriteLine(item);
            }
        }
    }
}
