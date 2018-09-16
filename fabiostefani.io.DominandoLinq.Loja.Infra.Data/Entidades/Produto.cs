using System;

namespace fabiostefani.io.DominandoLinq.Loja.Infra.Data.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; }
        public Guid IdCategoria { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
