using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class ProcedimentoController
    {
        public static Procedimento InserirProcedimento(
            string Descricao,
            double Preco
        )
        {
            if (String.IsNullOrEmpty(Descricao)) 
            {
                throw new Exception("Descrição é obrigatória");
            }

            if (Double.IsNaN(Preco) || Double.IsNegative(Preco))
            {
                throw new Exception("Preço inválido");
            }

            return new Procedimento(Descricao, Preco);
        }

        public static Procedimento AlterarProcedimento(
            int Id,
            string Descricao,
            double Preco
        )
        {
            Procedimento procedimento = GetProcedimento(Id);

            if (Double.IsNaN(Preco) || Double.IsNegative(Preco))
            {
                procedimento.Preco = Preco;
            }
            procedimento.Descricao = Descricao;

            return procedimento;
        }

        public static Procedimento ExcluirProcedimento(
            int Id
        )
        {
            Procedimento procedimento = GetProcedimento(Id);
            Models.Procedimento.RemoverProcedimento(procedimento);
            return procedimento;
        }

        public static List<Procedimento> VisualizarProcedimentos()
        {
            return Models.Procedimento.GetProcedimentos();
        }
        public static Procedimento GetProcedimento(
            int Id
        )
        {
            List<Procedimento> procedimentosModels = Models.Procedimento.GetProcedimentos();
            IEnumerable<Procedimento> procedimentos = from Procedimento in procedimentosModels
                            where Procedimento.Id == Id
                            select Procedimento;
            Procedimento procedimento = procedimentos.First();
            
            if (procedimento == null)
            {
                throw new Exception("Procedimento não encontrado");
            }

            return procedimento;
        }
    }
}