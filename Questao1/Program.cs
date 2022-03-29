using System;
using System.Collections.Generic;
using System.Threading;

namespace Questao1
{
    internal class Program
    {

        public static int[,] Groups = new int[,]
        {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10}
        };

        public static List<int> ListSums = new List<int>();


        static void Main(string[] args)
        {
            //1
            Thread thread = new Thread(() => SumOfIdexes(Groups));

            thread.Start();

            thread.Join();

            foreach (var itemSum in ListSums)
            {
                Console.WriteLine(itemSum);
            }
            Console.ReadKey();
        }

        private static void SumOfIdexes(int[,] indexes)
        {

            for (var i = 0; i < 2; i++)
            {
                var sum = 0;
                for (var j = 0; j < 5; j++)
                {
                    sum += indexes[i, j];
                }
                ListSums.Add(sum);
            }

        }
    }
}
