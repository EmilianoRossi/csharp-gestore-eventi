﻿using System;
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
        private protected DateTime dataEvento = new DateTime();
        private protected int numeroPostiTotale;
        private protected int numeroPostiPrenotati = 0;
        
        //Costruttore
        public Evento ( string titoloEvento , DateTime dataEvento , int numeroPostiTotale)
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

        public void SetData(DateTime dataEvento)
        {

            this.dataEvento = dataEvento;

        }

        public int GetPostiTotali()
        {

            return numeroPostiTotale;

        }

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

    }
}