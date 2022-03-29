using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press ENTER to start run");
            Console.ReadLine();

            List<Lebre> grupoLebres = new()
            {
                new Lebre("Pernalonga"),
                new Lebre("Toninho"),
                new Lebre("PernaCurta"),
            };


            Task taskLebre1 = Task.Factory.StartNew(() => grupoLebres[0].Saltar());
            Task taskLebre2 = Task.Factory.StartNew(() => grupoLebres[1].Saltar());
            Task taskLebre3 = Task.Factory.StartNew(() => grupoLebres[2].Saltar());


            Task.WaitAll(taskLebre1, taskLebre2, taskLebre3);

            ResultadoCorrida(grupoLebres);


            Console.ReadLine();
        }

        private static void ResultadoCorrida(List<Lebre> lebres)
        {
            List<Lebre> lebresOrdenadas = lebres.OrderBy(x => x.TempoFinalizacao).ToList();

            for (int i = 0; i < lebresOrdenadas.Count; i++)
            {
                Console.WriteLine(
                    $@"
                       {i+1}º Lugar
                       Nome: {lebresOrdenadas[i].Name}, 
                       Tempo: {lebresOrdenadas[i].TempoFinalizacao.ToString("HH:mm:ss.fff")}, 
                       Pulos: {lebresOrdenadas[i].QuantidadePulos}");
            }
        }
    }
}
