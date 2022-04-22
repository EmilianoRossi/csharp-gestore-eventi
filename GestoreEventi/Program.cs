
using GestoreEventi;
List<Evento> listaEventi = new List<Evento>();
string titoloEventi = "I miei eventi";
Console.WriteLine("Inserisci il numero di eventi da inserire");
int numeroAppuntamentiDaInserire = int.Parse(Console.ReadLine());
Console.WriteLine("------------- BENVENUTO NEL SOFTWERE EVENTI --------------");
for (int i = 0; i < numeroAppuntamentiDaInserire; i++)
{
    Console.WriteLine("------------ Inserisci il titolo dell'evento -------------");
    string titoloEvento = Console.ReadLine();

    Console.WriteLine("------- Inserisci la data dell'evento (gg/mm/yyyy) -------");
    string stringaData = Console.ReadLine();
    DateTime dataEvento = DateTime.Parse(stringaData);

    Console.WriteLine("---------- Inserisci il numero di posti totali -----------");
    int numeroPostiTotali = int.Parse(Console.ReadLine());

    Evento aggiungiEvento = new Evento(titoloEvento, dataEvento, numeroPostiTotali);
    listaEventi.Add(aggiungiEvento);
}
/*
Evento nuovoEvento = new Evento(titoloEvento, dataEvento, numeroPostiTotali);
nuovoEvento.Prenota();
nuovoEvento.Disdici();
nuovoEvento.ToString();*/

ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloEventi, listaEventi);

programmaEventi.NumeroEventi(listaEventi);
Console.WriteLine("------------- Informazioni Eventi --------------");
Console.WriteLine("Il nostro programma di: " + titoloEventi);
programmaEventi.StampaLista(listaEventi);

//string dataEventi = Console.ReadLine();
//DateTime dataUtente = DateTime.Parse(dataEventi);
//programmaEventi.SvuotaLista(listaEventi);
Console.WriteLine("Inserisci Data per cercare eventi");
string dataUtente=Console.ReadLine();
DateTime data = DateTime.Parse(dataUtente);


List<Evento> listaNuova = programmaEventi.CercaEvento(data);
programmaEventi.StampaLista(listaNuova);


Console.WriteLine();
