using fabiostefani.io.DominandoLinq.Loja.Dominio;
using System;
using System.Linq;

namespace fabiostefani.io.DominandoLinq.Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new Produto().Listar();
            produtos.Where(x=>x.Nome.Contains("x")).ToList().ForEach(x => EscreverNaTela(x));

            Console.WriteLine("VALOR MAIOR QUE 4");
            produtos.Where(x => x.Valor > 4).ToList().ForEach(x => EscreverNaTela(x));

            Console.ReadLine();
        }

        private static void EscreverNaTela(Produto produto)
        {
            Console.WriteLine($"Nome {produto.Nome} ");
            Console.WriteLine($"Quantidade {produto.Qtde} ");
            Console.WriteLine($"Valor {produto.Valor} ");
            Console.WriteLine("--------");
        }
    }
}
