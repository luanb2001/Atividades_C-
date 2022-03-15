using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class LeaoControllers
    {
        public static List<Leao> MostrarLeao()
        {
            return Leao.PuxarLeoes();
        }

        public static Leao InserirLeao(int id, string nome, int alimentacao, int visitantes)
        {
            return new Leao(id, nome, alimentacao, visitantes);
        }

        public static void AlterarLeao(int id, string nome, int alimentacao, int visitantes)
        { 
            Leao leaoAlterado;

            leaoAlterado = Leao.AlterarLeao(id, nome, alimentacao, visitantes);
        }

        public static Leao ExcluirLeao(int id)
        {
            Leao leaoExcluido;
            
            leaoExcluido = Leao.ExcluirLeao(id);

            if (leaoExcluido == null)
            {
                throw new Exception($"Leão não encontrado");
            }

            return leaoExcluido;
        }

    }
}