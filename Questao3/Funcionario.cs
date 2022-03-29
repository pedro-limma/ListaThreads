using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    public class Funcionario
    {
        public Funcionario(string name, string role, int idade)
        {
            Name = name;
            Role = role;
            Idade = idade;
        }

        public string Name { get; set; }
        public string Role { get; set;}
        public int Idade { get; set; }


    }
}
