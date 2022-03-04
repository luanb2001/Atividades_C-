using System;
using Controllers;
using Models;

namespace Views
{
    public class EspecialidadeView
    {
        public static void InserirEspecialidade()
        {
            Console.WriteLine("Digite a Descrição: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Tarefas: ");
            string Tarefas = Console.ReadLine();

            EspecialidadeController.InserirEspecialidade(
                Descricao,
                Tarefas
            );
        }

        public static void AlterarEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da Especialidade: ");
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
            Console.WriteLine("Digite a tarefa: ");
            string Tarefas = Console.ReadLine();

            EspecialidadeController.AlterarEspecialidade(
                Id,
                Descricao,
                Tarefas
            );

        }

        public static void ExcluirEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da Especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            EspecialidadeController.ExcluirEspecialidade(
                Id
            );

        }

        public static void ListarEspecialidades()
        {
            foreach (Especialidade item in EspecialidadeController.VisualizarEspecialidade())
            {
                Console.WriteLine(item);
            }
        }
    }
}