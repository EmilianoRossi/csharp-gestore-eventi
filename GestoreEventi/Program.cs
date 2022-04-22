using GestoreEventi;

Console.WriteLine("------------- BENVENUTO NEL SOFTWERE EVENTI --------------");

Console.WriteLine("------------ Inserisci il titolo dell'evento -------------");
string titoloEvento = Console.ReadLine();

Console.WriteLine("------- Inserisci la data dell'evento (gg/mm/yyyy) -------");
string stringaData = Console.ReadLine();
DateTime dataEvento = DateTime.Parse(stringaData);

Console.WriteLine("---------- Inserisci il numero di posti totali -----------");
int numeroPostiTotali = int.Parse(Console.ReadLine());

Evento nuovoEvento = new Evento(titoloEvento, dataEvento, numeroPostiTotali);
nuovoEvento.Prenota();
nuovoEvento.Disdici();
nuovoEvento.ToString(); 