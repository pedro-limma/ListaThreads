using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Corrida
    {
        public int DistanciaCorrida { get; } = 20;

        public void Largada()
        {
            var lebre1 = new Lebre("Pernalonga");
            var lebre2 = new Lebre("Toninho");
            var lebre3 = new Lebre("PernaCurta");


            Thread vaia1 = new Thread(() => lebre1.Saltar(DistanciaCorrida));
            Thread vaia2 = new Thread(() => lebre2.Saltar(DistanciaCorrida));
            Thread vaia3 = new Thread(() => lebre3.Saltar(DistanciaCorrida));

            vaia1.Start();
            vaia2.Start();
            vaia3.Start();


        }
    }
}
