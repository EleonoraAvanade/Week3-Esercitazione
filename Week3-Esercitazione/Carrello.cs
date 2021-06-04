using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Esercitazione
{
    class Dettaglio
    {
        public Prodotto prodotto;
        public int quantita=1;
        public double prezzo_tot;
        public double prezzo_tot_scontato;
        Dettaglio() { }
        public Dettaglio(Prodotto p, int q, double pt, double pts)
        {
            prodotto = p;
            quantita = q;
            prezzo_tot = pt;
            prezzo_tot_scontato = pts;
        }
        public override string ToString()
        {
            string str=prodotto.ToString()+" Quantità: "+Convert.ToString(quantita)+" Prezzo: "+Convert.ToString(prezzo_Tot())+" Prezzo totale scontato: "+Convert.ToString(prezzo_Tot_Scontato())+"\n";
            return str;
        }
        public double prezzo_Tot()
        {
            return quantita * prodotto.getPrezzo();
        }
        public double prezzo_Tot_Scontato()
        {
            return prezzo_Tot() * (prodotto.getSconto() / 100);
        }
    }
}
