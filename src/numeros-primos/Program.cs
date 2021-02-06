using System;
using System.Collections.Generic;
using System.Linq;

namespace numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 primeiros números primos
            var primos = ObterNumerosPrimos(10);

            for (int idx = 0; idx < primos.Count(); idx++)
                Console.WriteLine($"{idx}: {primos.ElementAt(idx)}");

            //5 primeiros números primos a partir do 5º
            var primos2 = ObterNumerosPrimos(5, 5);

            for (int idx = 0; idx < primos2.Count(); idx++)
                Console.WriteLine($"{idx}: {primos2.ElementAt(idx)}");
        }

        static IEnumerable<int> ObterNumerosPrimos(int quantidade)
        {
            var primos = new List<int>();

            //dever ser INTERIO e MAIOR que 1
            var ni = 2;
            var nn = ni;

            do
            {
                var primo = true;

                for (int div = (nn - 1); div >= ni; div--)
                {
                    if ((nn % div) == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo) primos.Add(nn);

                nn++;
            } while (primos.Count < quantidade);

            return primos;
        }

        static IEnumerable<int> ObterNumerosPrimos(int posicaoInicial, int quantidade)
            => ObterNumerosPrimos(posicaoInicial + quantidade)
                .Skip(posicaoInicial)
                .Take(quantidade);
    }
}
