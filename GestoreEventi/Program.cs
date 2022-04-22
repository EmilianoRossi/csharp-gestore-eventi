using GestoreEventi;
List<Evento> listaEventi = new List<Evento>();
string titoloEventi = "I miei eventi";
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

ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloEventi , listaEventi);

programmaEventi.NumeroEventi(listaEventi);
Console.WriteLine("------------- Informazioni Eventi --------------");
Console.WriteLine("Il nostro programma di: " + titoloEventi);
programmaEventi.StampaLista(listaEventi);

//string dataEventi = Console.ReadLine();
//DateTime dataUtente = DateTime.Parse(dataEventi);
programmaEventi.SvuotaLista(listaEventi);


//nuovoEventoDaAggiungere.AggiungiEvento(aggiungiEvento);
//nuovoEventoDaAggiungere.CercaEvento(dataEvento);
//ProgrammaEventi.StampaDati(listaEventi);
//nuovoEventoDaAggiungere.NumeroEventi(listaEventi);
//nuovoEventoDaAggiungere.SvuotaLista(listaEventi);
//nuovoEventoDaAggiungere.StampaLista(listaEventi);

Console.WriteLine();
