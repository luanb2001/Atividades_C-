using System;
using System.Collections.Generic;

namespace Models
{
    public class Atendimento
    {
        public static int ID = 0;
        private static List<Atendimento> Atendimentos = new List<Atendimento>();
        public int Id { set; get; }
        public int IdAgendamento{ set; get; }
        public Agendamento Agendamento { get; }
        public int IdProcedimento { set; get; }
        public Procedimento Procedimento { get; }


    public Atendimento(
            int IdAgendamento,
            int IdProcedimento
        ) : this(++ID, IdAgendamento, IdProcedimento)
        {}

    private Atendimento(
        int Id,
        int IdAgendamento,
        int IdProcedimento
        )
        {
            this.Id = Id;
            this.IdAgendamento = IdAgendamento;
            this.Agendamento = Agendamento.GetAgendamentos().Find(Agendamento => Agendamento.Id == IdAgendamento);
            this.IdProcedimento = IdProcedimento;
            this.Procedimento = Procedimento.GetProcedimentos().Find(Procedimento => Procedimento.Id == IdProcedimento);

            Atendimentos.Add(this);
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nPaciente: {this.Agendamento.Paciente.Nome}"
                + $"\nDentista: {this.Agendamento.Dentista.Nome}"
                + $"\nData: {this.Agendamento.Data}"
                + $"\nSala: {this.Agendamento.Sala.Numero}"
                + $"\nDescrição: {this.Procedimento.Descricao}"
                + $"\nPreço: {this.Procedimento.Preco}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Atendimento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Atendimento it = (Atendimento) obj;
            return it.Id == this.Id;
        }

        public static List<Atendimento> GetAtendimentos()
        {
            return Atendimentos;
        }
    }
}
