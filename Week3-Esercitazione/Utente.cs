using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Esercitazione
{
    class Utente
    {
        public string username;
        string password;
        string name;
        string surname;
        public List<Dettaglio> carrello = new List<Dettaglio>();
        public Utente() { }
        public Utente(string u, string p, string n, string s)
        {
            username = u;
            password = p;
            name = n;
            surname = s;
        }
        public string getName() { return name; }
        public string getSurname() { return surname; }
        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public void stampa()
        {
            Console.WriteLine("Riepilogo: \n");
            for(int i=0; i<carrello.Count; i++)
            {
                carrello[i].ToString();
            }
        }
        public bool Aggiungi_al_carrello(Prodotto p)
        {
            //carrello.Add(new Dettaglio());
            Console.WriteLine("Prodotto aggiunto correttamente!\n");
            return true;
        }
    }
}
