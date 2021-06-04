using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Esercitazione
{
    static class Gestione
    {
        public static int userAccess(ArrayList utenti)
        {
            Console.WriteLine("Fai l'accesso prima di procedere:\n" +
                "Username: ");
            string username = Console.ReadLine();
            for (int i = 0; i < utenti.Count; i++)
            {
                if (((Utente)utenti[i]).getUsername() == username)
                {
                    string password = null;
                    int cont = 0;
                    do
                    {
                        Console.WriteLine("Password: ");
                        password = Console.ReadLine();
                        cont++;
                        if (cont == 5)
                        {
                            Console.WriteLine("Dimenticato la psssword?\n" +
                                "La prossima volta scrivila da qualche parte! Byeeeee\n");
                            return -1;
                        }
                    } while (((Utente)utenti[i]).getPassword() != password);
                    return i;
                }
            }
            return -1;
        }
        public static int aggiungiUtente(ArrayList utenti)
        {
            Console.WriteLine("Iscriviti inserendo username, password, name, surname:\n" +
                "Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Password: ");
            string passWord = Console.ReadLine();
            Console.WriteLine("Name: ");
            string namE = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surName = Console.ReadLine();
            int index=utenti.Add(new Utente(userName, passWord, namE, surName));
            Console.WriteLine("Utente aggiunto con successo!\n");
            return index;
        }
        public static int Aggiungi_prodotto_al_carrello(Utente ut)
        {
            int choice=0;
            Console.WriteLine("Immetti il codice del prodotto: ");
            int codice = 0;
            do
            {
                Console.WriteLine("Prezzo: ");
            } while (!Int32.TryParse(Console.ReadLine(), out codice));
            Console.WriteLine("Descrizione: ");
            string descrizione = Console.ReadLine();
            double prezzo=0.0;
            do
            {
                Console.WriteLine("Prezzo: ");
            } while (!Double.TryParse(Console.ReadLine(), out prezzo));
            int sconto = 0;
            do
            {
                Console.WriteLine("Sconto: ");
            } while (!Int32.TryParse(Console.ReadLine(), out sconto));
            do
            {
                Console.WriteLine("Che tipo di prodotto è?\n" +
                    "Premi:\n1 se è d'abbigliamento\n" +
                    "2 se alimentare\n" +
                    "3 se elettronico\n");
            }while(!Int32.TryParse(Console.ReadLine(), out choice));
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Taglia: ");
                    string taglia = Console.ReadLine();
                    Console.WriteLine("Brand: ");
                    string brand=Console.ReadLine();
                    Prodotto_Abbigliamento prAB = new Prodotto_Abbigliamento(codice, descrizione, prezzo, sconto, taglia, brand);
                    break;
            }
            return -1;
        }
        public static bool Elimina_Prodotto(Utente ut)
        {
            bool check = false;
            int codice=0;
            do
            {
                Console.WriteLine("Immetti il codice del prodotto che vuoi eliminare: ");
            } while (!Int32.TryParse(Console.ReadLine(), out codice));
            for(int i=0; i<ut.carrello.Count; i++)
            {
                if (((Dettaglio)ut.carrello[i]).prodotto.getCodice() == codice)
                {
                    ut.carrello.RemoveAt(i);
                    Console.WriteLine("Oggetto rimosso correttamente\n");
                    return true;
                }
            }
            Console.WriteLine("Oggetto non trovato. \n");
            return check;
        }
    }
}
