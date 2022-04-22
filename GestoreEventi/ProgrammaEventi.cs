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

        /*public void CercaEvento(List<Evento> programmaEventi)
        {

            foreach(Evento evento in programmaEventi)
            {
                Console.WriteLine("Inserisci una data (gg/mm/yyyy) per vedere che eventi ci saranno");
                string dataUtente = Console.ReadLine ();
                DateTime data = DateTime.Parse(dataUtente);
                if (programmaEventi.Contains(evento.dataEvento))
                {

                    Console.WriteLine(data + " - " + titoloEvento);

                }
                else
                {

                    Console.WriteLine("Non ci sono eventi per questa data");

                }

            }

        }*/

        public static void StampaDati(List<Evento> listaEventi)
        {

            foreach (Evento evento in listaEventi)
            {

                evento.ToString();

            }

        }

        public void NumeroEventi(List<Evento> listaEventi)
        {
            int count = 0;
            for(int i = 0; i < listaEventi.Count; i++)
            {

                
                count++;

            }
            Console.WriteLine("Nel softwere ci sono: " + count + " eventi");
        }
            
        public void SvuotaLista(List<Evento> listaEventi)
        {

            listaEventi.Clear();
            Console.WriteLine("Lista cancellata correttamente");

        }

        public void StampaLista(List<Evento> listaEventi)
        {

            foreach(Evento evento in listaEventi)
            {

                evento.ToString ();

            }


        }
    }


}



