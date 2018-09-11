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

        public Produto(string nome, int qtde, decimal valor, DateTime dataVencimento, string categoria)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Qtde = qtde;
            Valor = valor;
            DataVencimento = dataVencimento;
            Categoria = categoria;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Qtde { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Categoria { get; set; }

        public List<Produto> ListarFrutas()
        {
            _produtos.Add(new Produto("Banana", 5, 3, DateTime.Now.AddDays(5), "Fruta"));
            _produtos.Add(new Produto("Morango", 4, 6, DateTime.Now.AddDays(4), "Fruta"));
            _produtos.Add(new Produto("Pera", 2, 7, DateTime.Now.AddDays(5), "Fruta"));
            _produtos.Add(new Produto("Abacaxi", 1, 8, DateTime.Now.AddDays(5), "Fruta"));
            _produtos.Add(new Produto("Melao", 35, 9, DateTime.Now.AddDays(5), "Fruta"));
            _produtos.Add(new Produto("Laranja", 1, 2, DateTime.Now.AddDays(5), "Fruta"));
            return _produtos;
        }

        public List<Produto> ListarEletronicos()
        {
            _produtos.Add(new Produto("Iphone", 5, 7900, DateTime.Now.AddDays(5), "Eletrônico"));
            _produtos.Add(new Produto("Galaxy", 4, 4500, DateTime.Now.AddDays(4), "Eletrônico"));
            _produtos.Add(new Produto("Pen Drive", 2, 30, DateTime.Now.AddDays(5), "Eletrônico"));            
            return _produtos;
        }


    }
}
