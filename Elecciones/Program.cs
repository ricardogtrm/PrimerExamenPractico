using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> personasVotantes = new List<string>();
            personasVotantes.Add("Ernesto,1");
            personasVotantes.Add("Raul,3");
            personasVotantes.Add("Joaquin,2");
            personasVotantes.Add("Araceli,1");
            personasVotantes.Add("Maria,2");
            personasVotantes.Add("Teresa,1");
            personasVotantes.Add("Marco,2");
            personasVotantes.Add("Margarita,3");
            personasVotantes.Add("Arlet,1");
            personasVotantes.Add("Margalet,4");
            personasVotantes.Add("Jonas,1");
            personasVotantes.Add("Alexa,2");

            ContarVotos(personasVotantes);
            Console.ReadKey();
        }

        private static void ContarVotos(List<string> votos)
        {
            List<string> votosCandidato1 = new List<string>();
            List<string> votosCandidato2 = new List<string>();
            List<string> votosCandidato3 = new List<string>();
            List<string> votosAnulados = new List<string>();

            foreach (var persona in votos)
            {
                string[] valores = persona.Split(',');
                if (valores[1] == "1")
                {
                    votosCandidato1.Add(persona);
                }
                else if (valores[1] == "2")
                {
                    votosCandidato2.Add(persona);
                }
                else if (valores[1] == "3")
                {
                    votosCandidato3.Add(persona);
                }
                else
                {
                    votosAnulados.Add(persona);
                }
            }
            MostrarGanador(votosCandidato1, votosCandidato2, votosCandidato3);
        }

        private static void MostrarGanador(List<string> candidato1, List<string> candidato2, List<string> candidato3)
        {
            if (candidato1.Count > candidato2.Count && candidato1.Count > candidato3.Count)
            {
                Console.WriteLine("El candidato 1 gano con: " + candidato1.Count + " votos");
            }
            else if (candidato2.Count > candidato1.Count && candidato2.Count > candidato3.Count)
            {
                Console.WriteLine("El candidato 2 gano con: " + candidato2.Count + " votos");
            }
            else if (candidato3.Count > candidato1.Count && candidato3.Count > candidato2.Count)
            {
                Console.WriteLine("El candidato 3 gano con: " + candidato3.Count + " votos");
            }
            else
            {
                Console.WriteLine("Empate entre candidatos, se muestran los votos de los 3");
                Console.WriteLine("Candidato 1: " + candidato1.Count + " votos");
                Console.WriteLine("Candidato 2: " + candidato2.Count + " votos");
                Console.WriteLine("Candidato 3: " + candidato3.Count + " votos");
            }
        }
    }
}
