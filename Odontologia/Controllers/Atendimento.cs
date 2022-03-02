using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class AtendimentoController
    {
        public static Atendimento InserirAtendimento(
        int IdAgendamento,
        int IdProcedimento
        )
        {
            AgendamentoController.GetAgendamento(IdAgendamento);
            ProcedimentoController.GetProcedimento(IdProcedimento);

            if (IdAgendamento < 0)
                {
                    throw new Exception("O ID de agendamento necessita ser maior que 0");
                }

            if (IdProcedimento < 0)
                {
                    throw new Exception("O ID de procedimento necessita ser maior que 0");
                }

            return new Atendimento(IdAgendamento, IdProcedimento);
        }
        public static List<Atendimento> VisualizarAtendimentos()
        {
            return Models.Atendimento.GetAtendimentos();
        }
        public static Atendimento GetAtendimento(
            int Id
        )
        {
            List<Atendimento> atendimentosModels = Models.Atendimento.GetAtendimentos();
            IEnumerable<Atendimento> atendimentos = from Atendimento in atendimentosModels
                            where Atendimento.Id == Id
                            select Atendimento;
            Atendimento atendimento = atendimentos.First();
            
            if (atendimento == null)
            {
                throw new Exception("Atendimento não encontrado");
            }

            return atendimento;
        }
    }
}