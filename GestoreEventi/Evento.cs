using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{

    //Classe
    internal class Evento
    {
        //Attributi
        private protected string titoloEvento;
        public DateTime dataEvento = new DateTime();
        private protected int numeroPostiTotale;
        private protected int numeroPostiPrenotati = 0;
        
        //Costruttore
        public Evento ( string titoloEvento, DateTime dataEvento , int numeroPostiTotale)
        {

            this.titoloEvento = titoloEvento;
            this.dataEvento = dataEvento;
            this.numeroPostiTotale = numeroPostiTotale;
            

        }

        //Get E Set

        public void SetTitolo(string titoloEvento)
        {

            this.titoloEvento = titoloEvento;

        }

        public DateTime GetData()
        {

            return dataEvento;

        }

        public int GetPostiTotali()
        {

            return numeroPostiTotale;

        }

        //metodo prenota
        public void Prenota()
        {
            int numeroPostiDisponibili;
            Console.WriteLine("Vuoi prenotare dei posti? [si/no]");
            string risposta=Console.ReadLine();
            switch (risposta)
            {

                case "si":

                    Console.WriteLine("Quanti posti vuoi prenotare?");
                    this.numeroPostiPrenotati = int.Parse(Console.ReadLine());
                    this.numeroPostiTotale -= this.numeroPostiPrenotati;
                    Console.WriteLine("Numero posti prenotati: " + this.numeroPostiPrenotati);
                    Console.WriteLine("Numero posti disponibili: " + this.numeroPostiTotale);
                    Disdici();

                    break;

                case "no":
                    
                    
                    break;

            }

        }

        //metodo disdici
        public void Disdici()
        {

            Console.WriteLine("Vuoi disdire dei posti? [si/no]");
            string risposta = Console.ReadLine();
            switch (risposta)
            {

                case "si":

                    if (numeroPostiPrenotati == 0)
                    {

                        Console.WriteLine("Non hai prenotato nessun posto");
                        Prenota();
                        break;

                    }
                    else
                    {

                        Console.WriteLine("Quanti posti vuoi disdire?");
                        int numeroPostiDisdetti = int.Parse(Console.ReadLine());
                        this.numeroPostiPrenotati -= numeroPostiDisdetti;
                        this.numeroPostiTotale += numeroPostiDisdetti;
                        Console.WriteLine("Numero posti prenotati: " + this.numeroPostiPrenotati);
                        Console.WriteLine("Numero posti disponibili: " + this.numeroPostiTotale);
                        break;

                    }

                case "no":

                    Console.WriteLine("Vabene arrivederci!");
                    break;

            }
        }

            //Override metodo to string

            public override string ToString()
            {

            //Console.WriteLine("Vuoi stampare l'evento? [si/no]");
            //string risposta = Console.ReadLine();

            //switch (risposta)
            //{

            //case "si":
            string stringa = "";
            stringa = this.titoloEvento + " - " + this.dataEvento;

            return stringa;
                        
                        //break;

                    //case "no":
                        //Console.WriteLine("Grazie e arrivederci");
                        //break;
                //}

            } 

    }

}
