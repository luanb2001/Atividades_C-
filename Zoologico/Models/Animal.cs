using System;

namespace Models
{
    public class Animal
    {
        protected int id { get; set; }
        protected string nome { get; set; }

        public Animal(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}