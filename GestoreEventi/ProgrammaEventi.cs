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

        public string GetTitolo()
        {

            return titoloEvento;

        }

        public void AggiungiEvento(Evento nuovoEvento)
        {

            programmaEventi.Add (nuovoEvento);

        }

        public List<Evento> CercaEvento(DateTime data)
        {

            List<Evento> lista = new List<Evento>();

            for (int i = 0; i < programmaEventi.Count; i++) {

                
                
                if(this.programmaEventi[i].GetData() == data)
                {

                    lista.Add (programmaEventi[i]);

                }
                
            }
            return lista;
        }


        public void StampaDati (List<Evento> listaEventi)
        {

            foreach (Evento evento in listaEventi)
            {

                Console.WriteLine(evento.ToString());

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

                Console.WriteLine(evento.ToString ());

            }


        }
    }


}



