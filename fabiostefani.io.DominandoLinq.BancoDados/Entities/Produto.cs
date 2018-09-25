using System;

namespace fabiostefani.io.DominandoLinq.BancoDados.Entities
{
    public class Produto
    {
        protected Produto()
        {

        }

        public Produto(string nome, Guid idCategoria, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            IdCategoria = idCategoria;
            Valor = valor;
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid IdCategoria { get; set; }        
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }

    }
}
