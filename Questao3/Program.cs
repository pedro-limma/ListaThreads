using System;
using System.Collections.Generic;

namespace Questao3
{
    internal class Program
    {

        public static List<Funcionario> ListaFuncionarios;
        static void Main(string[] args)
        {
            var arrayFuncionarios = new Funcionario[] 
            { 
                new Funcionario("Givaldo", "Mendigo", 48),
                new Funcionario("Renílson", "Pedreiro", 40),
                new Funcionario("Luiza", "Médica", 25),
                new Funcionario("Bruno", "Desenvolvedor", 23),
                new Funcionario("Casseb", "Empresário", 40),
                new Funcionario("Fabinho", "CEO", 46),
                new Funcionario("Shirley", "Gerente", 40),
                new Funcionario("Tomé", "Brincante", 23),
                new Funcionario("Gabriel", "GP", 25),
                new Funcionario("Neymar", "Jogador", 30),
            };



            
        }

        private void PopulaListaFuncionarios()
        {

        }
    }
}
