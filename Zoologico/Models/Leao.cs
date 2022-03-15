using System;
using System.Collections.Generic;

namespace Models
{
    public class Leao : Animal
    {
        private static List<Leao> leoes = new List<Leao>();
        public int alimentacao { get; set; }
        public int visitantes { get; set; }

        public Leao(int id, string nome, int alimentacao, int visitantes) : base(id, nome)
        {
            this.id = id;
            this.nome = nome;
            this.alimentacao = alimentacao;
            this.visitantes = visitantes;

            leoes.Add(this);
        }

        public static List<Leao> PuxarLeoes()
        {
            return leoes;
        }

        public static Leao ExcluirLeao(int id)
        {
            Leao leao = leoes.Find(leao => leao.id == id);

            leoes.Remove(leao);

            return leao;

        }

        public static Leao AlterarLeao(int id, string nome, int alimentacao, int visitantes)
        {

            Leao leao = leoes.Find(leao => leao.id == id);

            leao.id = id;
            leao.nome = nome;
            leao.alimentacao = alimentacao;
            leao.visitantes = visitantes;

            return leao;
        }

        public override string ToString()
        {
            return $"\nId: {id}\nNome: {nome}\nAlimentação: {alimentacao}\nVisitantes: {visitantes}\n";
        }
    }
}