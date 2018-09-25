using System;

namespace fabiostefani.io.DominandoLinq.BancoDados.Entities
{
    public class Categoria
    {
        protected Categoria()
        {

        }
        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
    }
}
