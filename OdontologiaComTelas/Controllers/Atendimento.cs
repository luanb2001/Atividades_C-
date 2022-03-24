using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class AtendimentoController
    {
        public static Atendimento InserirAtendimento(
        int AgendamentoId,
        int ProcedimentoId
        )
        {
            AgendamentoController.GetAgendamento(AgendamentoId);
            ProcedimentoController.GetProcedimento(ProcedimentoId);

            if (AgendamentoId < 0)
                {
                    throw new Exception("O ID de agendamento necessita ser maior que 0");
                }

            if (ProcedimentoId < 0)
                {
                    throw new Exception("O ID de procedimento necessita ser maior que 0");
                }

            return new Atendimento(AgendamentoId, ProcedimentoId);
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