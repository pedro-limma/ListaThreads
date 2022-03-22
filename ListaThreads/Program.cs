using System;
using System.Threading;

namespace ListaThreads
{
    internal class Program
    {

        public static int TotalSum = 0;
        public static int[,] Groups =
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10}
            };
        static void Main(string[] args)
        {
            //1
            Thread t = new Thread(new ThreadStart(SumOfIndexes));
            t.Start();

            Console.WriteLine("Thread Principal fazendo Join() da Thread ");
            Console.WriteLine("Pressione alguma tecla para continuar ...");
            Console.ReadLine();
            t.Join();
            Console.WriteLine($"Retorno de SumOfIndexes: {TotalSum}");
            Console.ReadLine();
        }

        public static void SumOfIndexes()
        {
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    TotalSum += Groups[linha, coluna];
                    Thread.Sleep(1);
                }
            }
        }
    }
}
