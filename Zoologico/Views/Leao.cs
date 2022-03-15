using System;
using Controllers;
using Models;

namespace Views
{
    public class LeaoViews
    {
        public static void InicioPrograma()
        {

            int opcao = 0;
            do
            {
                Console.WriteLine("1 - Inserir, 2 - Mostrar, 3 - Alterar, 4 - Excluir");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Inserir Leões\n");
                        Console.Write("Id: ");
                        int id = Convert.ToInt16(Console.ReadLine());

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Refeições diárias: ");
                        int alimentacao = Convert.ToInt16(Console.ReadLine());

                        Console.Write("Visitantes diários: ");
                        int visitantes = Convert.ToInt16(Console.ReadLine());

                        LeaoControllers.InserirLeao(id, nome, alimentacao, visitantes);
                        break;
                    
                    case 2:
                        Console.WriteLine("Mostrar Leões");

                        foreach(Leao leao in LeaoControllers.MostrarLeao())
                        {
                            Console.WriteLine(leao);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Alterar Leões");
                        Console.Write("Id: ");
                        id = Convert.ToInt16(Console.ReadLine());

                        Console.Write("Nome: ");
                        nome = Console.ReadLine();

                        Console.Write("Refeições diárias: ");
                        alimentacao = Convert.ToInt16(Console.ReadLine());

                        Console.Write("Visitantes diários: ");
                        visitantes = Convert.ToInt16(Console.ReadLine());
                        
                        LeaoControllers.AlterarLeao(id, nome, alimentacao, visitantes);
                        break;

                    case 4:
                        Console.WriteLine("Excluir Leões");
                        Console.Write("Id de exclusão: ");
                        id = Convert.ToInt16(Console.ReadLine());

                        LeaoControllers.ExcluirLeao(id);
                        break;
                    
                    default:
                        break;
                }
            } while (opcao != 0);
            

        }
    }
}