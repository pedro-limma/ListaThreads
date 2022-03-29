using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Questao2
{
    public class Lebre
    {
        public int DistanciaAtual { get; private set; } = 0;
        public string Name { get; private set; }
        public int QuantidadePulos { get; private set; }

        public Lebre(string name)
        {
            Name = name;
        }

        public void Saltar()
        {
            var random = new Random().Next(1, 4);
            
            DistanciaAtual += random;
            QuantidadePulos++;

            Console.WriteLine($"Lebre {Name} pulou {random} metros");
            Thread.Sleep(1000);

        }
    }
}
