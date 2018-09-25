using fabiostefani.io.DominandoLinq.BancoDados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.BancoDados.Persistence.Repositories
{
    public class RepCategoria
    {
        private readonly LojaContext _context;
        public RepCategoria(LojaContext context)
        {
            _context = context;
        }

        public void LimparRegistros()
        {
            Recuperar().ForEach(x => _context.Categoria.Remove(x));
            _context.SaveChanges();
        }

        public List<Categoria> Recuperar()
        {            
            return _context.Categoria.ToList();
        }

        public Categoria Adicionar(string nome)
        {
            var categoria = new Categoria(nome);
            _context.Categoria.Add(categoria);
            _context.SaveChanges();

            return categoria;
        }
    }
}


