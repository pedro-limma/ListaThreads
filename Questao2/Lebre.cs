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
        public DateTime TempoFinalizacao { get; private set; }

        public Lebre(string name)
        {
            Name = name;
        }

        public void Saltar()
        {
            while (DistanciaAtual <= 20)
            {
                var salto = new Random().Next(1, 4);
            
                DistanciaAtual += salto;
                QuantidadePulos++;

                Console.WriteLine($"Lebre {Name} pulou {salto} metros");
                Thread.Sleep(TimeSpan.FromSeconds(new Random().NextDouble() * salto));
            }
            TempoFinalizacao = DateTime.Now;
            
        }
    }
}
