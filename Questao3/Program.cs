using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Questao3
{
    internal class Program
    {

        public static List<Funcionario> ListaFuncionarios = new List<Funcionario>();
        static void Main(string[] args)
        {
            var arrayFuncionarios = new Funcionario[]
            {
                new Funcionario("Givaldo", "Mendigo", 48),
                new Funcionario("Renílson", "Pedreiro", 40),
                new Funcionario("Luiza", "Médica", 25),
                new Funcionario("Bruno", "Desenvolvedor", 23),
                new Funcionario("Casseb", "Empresário", 40),
                new Funcionario("Fabinho", "CEO", 35),
                new Funcionario("Shirley", "Gerente", 24),
                new Funcionario("Tomé", "Brincante", 23),
                new Funcionario("Gabriel", "GP", 25),
                new Funcionario("Neymar", "Jogador", 30),
            };


            Task populaListaFuncionario = Task.Factory.StartNew(() => PopulaListaFuncionarios(arrayFuncionarios));

            Task.WaitAll(populaListaFuncionario);

            foreach (var funcionario in ListaFuncionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
            Console.ReadLine();
        }

        private static void PopulaListaFuncionarios(Funcionario[] arrayFuncionarios)
        {
            foreach (var funcionario in arrayFuncionarios)
            {
                if (funcionario.Idade > 25)
                    ListaFuncionarios.Add(funcionario);
            }
        }
    }
}
