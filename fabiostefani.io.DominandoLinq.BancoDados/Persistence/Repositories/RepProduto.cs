using fabiostefani.io.DominandoLinq.BancoDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.BancoDados.Persistence.Repositories
{
    public class RepProduto
    {
        private readonly LojaContext _context;
        public RepProduto(LojaContext context)
        {
            _context = context;
        }
        public List<Produto> Recuperar()
        {            
            return _context.Produto.ToList();
        }

        public void LimparRegistros()
        {
            Recuperar().ForEach(x => _context.Produto.Remove(x));
            _context.SaveChanges();
        }

        public void Adicionar(string nome, Guid idCategoria, decimal valor)
        {
            var produto = new Produto(nome, idCategoria, valor);
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }
    }
}

