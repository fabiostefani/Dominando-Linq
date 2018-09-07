using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            
            numeros.ToList().ForEach(x => Console.WriteLine(x)) ;

            numeros.ToList().ForEach(x => EscreverNaTela(x));

            Console.ReadLine();
        }

        private static void EscreverNaTela(int numero)
        {
            Console.WriteLine(numero);
        }
    }
}
