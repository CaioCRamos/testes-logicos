using System;
using System.Collections.Generic;
using System.Linq;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //obtendo os 25 primeiros números da sequência de Fibonacci
            var numeros = ObterSequenciaFibonacci(25);

            for (int idx = 0; idx < numeros.Count(); idx++)
                Console.WriteLine($"{idx}: {numeros.ElementAt(idx)}");

            //obtendo os 5 primeiros números da sequência de Fibonacci a partir do 20º número
            var posicaoInicial = 20;
            var quantidade = 5;
            var numeros2 = ObterSequenciaFibonacci(posicaoInicial, quantidade);

            for (int idx = 0; idx < numeros2.Count(); idx++)
                Console.WriteLine($"{(idx + posicaoInicial)}: {numeros2.ElementAt(idx)}");
        }

        static IEnumerable<long> ObterSequenciaFibonacci(int quantidade)
        {
            long f0 = 0;
            long f1 = 1;

            var numeros = new List<long> { f0, f1 };

            for (var idx = 1; idx <= (quantidade - 2); idx++)
            {
                var fn = f1 + f0;
                f0 = f1;
                f1 = fn;

                numeros.Add(fn);
            }

            return numeros;
        }

        static IEnumerable<long> ObterSequenciaFibonacci(int posicaoInicial, int quantidade)
            => ObterSequenciaFibonacci(posicaoInicial + quantidade)
                .Skip(posicaoInicial)
                .Take(quantidade);
    }
}
