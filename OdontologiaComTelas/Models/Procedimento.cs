using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Procedimento
{
        public int Id { set; get; }
        [Required]
        public string Descricao { set; get; }
        [Required]
        public double Preco { set; get; }

        public override string ToString()
        {
            return base.ToString()
                + $"\nDiscrição: {this.Descricao}" 
                + $"\nPreço: R$ {this.Preco}";
        }

        public Procedimento(){}
        
        public Procedimento(
            string Descricao,
            double Preco
        )
        {
            this.Descricao = Descricao;
            this.Preco = Preco;
            Context db = new Context();
            db.Procedimentos.Add(this);
            db.SaveChanges();
        }



        public static List<Procedimento> GetProcedimentos()
        {
            Context db = new Context();
            return (from Procedimento in db.Procedimentos select Procedimento).ToList();
        }

        public static void RemoverProcedimento(Procedimento procedimento)
        {
            Context db = new Context();
            db.Procedimentos.Remove(procedimento);
        }

    }
}