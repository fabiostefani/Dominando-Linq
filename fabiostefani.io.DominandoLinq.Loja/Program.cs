using fabiostefani.io.DominandoLinq.Loja.Dominio;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace fabiostefani.io.DominandoLinq.Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            //var produtos = new Produto().Listar();
            //produtos.Where(x=>x.Nome.Contains("x"))
            //        .ToList()
            //        .ForEach(x => EscreverNaTela(x));

            //Console.WriteLine("VALOR MAIOR QUE 4");
            //produtos.Where(x => x.Valor > 4)
            //        .ToList()
            //        .ForEach(x => EscreverNaTelajJson(x));

            Intersect();
            Except();

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
