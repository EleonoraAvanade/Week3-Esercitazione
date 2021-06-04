using System.Collections;
using System;
using System.Collections.Generic;

namespace Week3_Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList utenti = new ArrayList();
            Console.WriteLine("Benvenuto al tuo e-market preferito!\n");
            while (true)
            {
                int num=0;
                int utenteInQUestione = -1;
                do {
                    Console.WriteLine("1 - Accedi\n" +
                        "2 - Iscriviti\n" +
                        "3 - Esci\n");
                } while (!Int32.TryParse(Console.ReadLine(), out num));
                switch (num)
                {
                    case 1:
                        int accesso = Gestione.userAccess(utenti);
                        if (accesso == -1) return;
                        utenteInQUestione = accesso;
                        break;
                    case 2:
                        utenteInQUestione = Gestione.aggiungiUtente(utenti);
                        break;
                    default:
                        Console.WriteLine("Bye bye\n");
                        return;
                }
                while (true)
                {
                    int choice;
                    do
                    {
                        Console.WriteLine("Scegli tra le seguenti immettendo il numero corrispondente all'operazione desiderata:\n" +
                            "1 - Aggiungi un prodotto al carrello\n" +
                            "2 - Elimina un prodotto\n" +
                            "3 - Modifica la quantità di un prodotto specifico\n" +
                            "4 - Riepilogo carrello\n" +
                            "QUALUNQUE NUMERO DIVERSO DA I NUMERI SOPRA UTILIZZATI - Exit\n");
                    } while (!Int32.TryParse(Console.ReadLine(), out choice));
                    switch (choice)
                    {
                        case 1:
                            Gestione.Aggiungi_prodotto_al_carrello((Utente)utenti[utenteInQUestione]);
                            break;
                        case 2:
                            Gestione.Elimina_Prodotto((Utente)utenti[utenteInQUestione]);
                            break;
                        case 3:
                            Gestione.Elimina_Prodotto((Utente)utenti[utenteInQUestione]);
                            break;
                        case 4:
                            ((Utente)utenti[utenteInQUestione]).stampa();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Closing...\n" +
                                "Arrivederci!\n");
                            break ;
                    }
                    if (choice < 1 || choice > 4) break;
                }
            }
        }
    }
}
