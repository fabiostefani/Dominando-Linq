using System;
using System.Collections.Generic;

namespace fabiostefani.io.DominandoLinq.Loja.Dominio
{
    public class Produto
    {
        private List<Produto> _produtos;

        public Produto()
        {
            _produtos = new List<Produto>();            
        }

        public Produto(string nome, int qtde, decimal valor, DateTime dataVencimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Qtde = qtde;
            Valor = valor;
            DataVencimento = dataVencimento;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Qtde { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataVencimento { get; private set; }

        public List<Produto> Listar()
        {
            _produtos.Add(new Produto("Banana", 5, 3, DateTime.Now.AddDays(5)));
            _produtos.Add(new Produto("Morango", 4, 6, DateTime.Now.AddDays(4)));
            _produtos.Add(new Produto("Pera", 2, 7, DateTime.Now.AddDays(5)));
            _produtos.Add(new Produto("Abacaxi", 1, 8, DateTime.Now.AddDays(5)));
            _produtos.Add(new Produto("Melao", 35, 9, DateTime.Now.AddDays(5)));
            _produtos.Add(new Produto("Laranja", 1, 2, DateTime.Now.AddDays(5)));
            return _produtos;
        }
        

    }
}
