using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.DominandoLinq.Paralelismo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int qtde = 100000;
                string tempoProcessamentoNormal = ProcessamentoNormal(qtde);
                string tempoProcessamentoParalelo = ProcessamentoParalelo(qtde);

                EscreverNaTela($"Tempo de processamento normal {tempoProcessamentoNormal}");
                EscreverNaTela($"Tempo de processamento paralelo {tempoProcessamentoParalelo}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {

                EscreverNaTela("Erro " + ex.Message);
            }
            
        }

        private static string ProcessamentoParalelo(int qtde)
        {
            var sw = new Stopwatch();
            sw.Start();
            Parallel.For(0, qtde, index => 
            {
                EscreverNaTela($"Escrevendo a linha {index}");
            });
            
            sw.Stop();
            return sw.Elapsed.ToString();
        }

        private static string ProcessamentoNormal(int qtde)
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < qtde; i++)
            {
                EscreverNaTela($"Escrevendo a linha {i}");
            }
            sw.Stop();
            return sw.Elapsed.ToString();
        }

        private static void EscreverNaTela(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
