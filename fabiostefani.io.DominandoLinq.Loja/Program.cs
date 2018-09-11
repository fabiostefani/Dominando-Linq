using fabiostefani.io.DominandoLinq.Loja.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fabiostefani.io.DominandoLinq.Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();
            var frutas = produto.ListarFrutas();
            var eletronicos = produto.ListarEletronicos();

            var produtos = new List<Produto>();
            produtos.AddRange(frutas);
            produtos.AddRange(eletronicos);
            produtos.ForEach(x => EscreverNaTela(x));
            Console.WriteLine("------------------------------------");
            var agrupCategoria = (from p in produtos                                  
                                  group p by p.Categoria into agrup                                  
                                  orderby agrup.Key
                                  select new
                                  {
                                      Categoria = agrup.Key,
                                      ValorMax = agrup.Max(x => x.Valor),
                                      ValorMin = agrup.Min(x=>x.Valor),
                                      ValorTotal = agrup.Sum(x=>x.Qtde * x.Valor)
                                  }).ToList();

            agrupCategoria.ForEach(x =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(x));
            });

            //Console.WriteLine("VALOR MAIOR QUE 4");
            //produtos.Where(x => x.Valor > 4)
            //        .ToList()
            //        .ForEach(x => EscreverNaTelajJson(x));

            //Intersect();
            //Except();

            Console.ReadLine();
        }

        private static void Intersect()
        {
            var numeroPares = new int[] { 2, 4, 6, 8, 10 };
            var numeroImpares = new int[] { 1, 3, 5, 7, 9 };

            var numerosMisturados = new int[] { 1, 2, 3, 4 };

            var existeNumerosPares = numerosMisturados.Intersect(numeroPares);
            Console.WriteLine("Intersect");
            existeNumerosPares.ToList().ForEach(x => Console.WriteLine(x));


        }

        private static void Except()
        {
            var numeroPares = new int[] { 2, 4, 6, 8, 10 };
            var numeroImpares = new int[] { 1, 3, 5, 7, 9 };

            var numerosMisturados = new int[] { 1, 2, 3, 4 };

            var existeNumerosPares = numerosMisturados.Except(numeroPares);
            Console.WriteLine("Except");
            existeNumerosPares.ToList().ForEach(x => Console.WriteLine(x));


        }

        private static void EscreverNaTela(Produto produto)
        {
            Console.WriteLine($"Nome {produto.Nome} ");
            Console.WriteLine($"Quantidade {produto.Qtde} ");
            Console.WriteLine($"Valor {produto.Valor} ");
            Console.WriteLine("--------");
        }

        private static void EscreverNaTelajJson(Produto produto)
        {
            Console.WriteLine(JsonConvert.SerializeObject(produto));
            Console.WriteLine();
        }
    }
}
