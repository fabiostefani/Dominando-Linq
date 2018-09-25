using fabiostefani.io.DominandoLinq.BancoDados.Persistence;
using fabiostefani.io.DominandoLinq.BancoDados.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.BancoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LojaContext())
            {
                var repCategoria = new RepCategoria(context);
                var repProduto = new RepProduto(context);

                repProduto.LimparRegistros();
                repCategoria.LimparRegistros();
                

                var catFrutas = repCategoria.Adicionar("Frutas");
                var catEletronicos = repCategoria.Adicionar("Eletrônicos");

                var aa = repCategoria.Recuperar();

                
                repProduto.Adicionar("IphoneX 2", catEletronicos.Id, 100);
                repProduto.Adicionar("Nokia 1100", catEletronicos.Id, 5);
                repProduto.Adicionar("Samsung J9", catEletronicos.Id, 50);

                repProduto.Adicionar("Morango", catFrutas.Id, 3.98m);
                repProduto.Adicionar("Melancia", catFrutas.Id, 1.89m);
                var produtos = repProduto.Recuperar();
            }
            
            Console.ReadKey();
        }
    }
}
