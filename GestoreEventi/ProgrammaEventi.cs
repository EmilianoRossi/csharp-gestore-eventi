using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    //Classe
    internal class ProgrammaEventi
    { 
        //Attributi
        private protected string titoloEvento;
        private protected List <Evento> programmaEventi = new List <Evento> ();


        //Costruttore
        public ProgrammaEventi(string titoloEvento, List<Evento> programmaEventi)
        {

            this.titoloEvento = titoloEvento;
            this.programmaEventi = programmaEventi;

        }

        public void AggiungiEvento(Evento nuovoEvento)
        {

            programmaEventi.Add (nuovoEvento);

        }

        public void CercaEvento(DateTime dataEvento)
        {

            foreach(Evento evento in programmaEventi)
            {
                Console.WriteLine("Inserisci una data (gg/mm/yyyy) per vedere che eventi ci saranno");
                string dataUtente = Console.ReadLine ();
                DateTime data = DateTime.Parse(dataUtente);
                if (dataEvento == data)
                {

                    Console.WriteLine(data + " - " + titoloEvento);

                }
                else
                {

                    Console.WriteLine("Non ci sono eventi per questa data");

                }

            }

        }

        public static void StampaEventi()
        {

            foreach(Evento evento in programmaEventi)
            {



            }

        }

    }
}
