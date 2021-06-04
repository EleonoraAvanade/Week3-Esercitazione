using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Esercitazione
{
    class Prodotto
    {
        public int codice;
        public string descrizione;
        public double prezzo;
        public int sconto;
        public Prodotto(int c, string d, double p, int s)
        {
            codice = c;
            descrizione = d;
            prezzo = p;
            sconto = s;
        }
        public int getCodice() { return codice; }
        public string getDescrizione() { return descrizione; }
        public double getPrezzo() { return prezzo; }
        public int getSconto() { return sconto; }
        public override string ToString()
        {
            string str = "\nCodice: " + Convert.ToString(codice) + "\nDescrizione: " + descrizione + "\nPrezzo: " + Convert.ToString(prezzo) + "\nSconto: " + Convert.ToString(sconto) + "%\n";
            return str;
        }
    }
    class Prodotto_Abbigliamento:Prodotto
    {
        string taglia;
        string brand;
        public Prodotto_Abbigliamento(int c, string d, double p, int s, string t, string b):base( c,  d,  p,  s)
        {
            this.codice = c;
            this.descrizione = d;
            this.prezzo = p;
            this.sconto = s;
            this.taglia = t;
            this.brand = b;
        }
        public override string ToString()
        {
            return base.ToString()+ "\nTaglia: "+taglia+"\nBrand: "+brand;
        }
    }
    class Prodotto_Alimentari:Prodotto
    {
        DateTime scadenza;
        public Prodotto_Alimentari(int c, string d, double p, int s, DateTime sc) : base(c, d, p, s)
        {
            this.codice = c;
            this.descrizione = d;
            this.prezzo = p;
            this.sconto = s;
            this.scadenza = sc;
        }
        public override string ToString()
        {
            return base.ToString()+"\nScadenza: "+scadenza+"\n";
        }
    }
    class Prodotto_Elettronica:Prodotto
    {
        string produttore;
        public Prodotto_Elettronica(int c, string d, double p, int s, string pr):base(c, d, p, s)
        {
            this.codice = c;
            this.descrizione = d;
            this.prezzo = p;
            this.sconto = s;
            this.produttore = pr;
        }
        public override string ToString()
        {
            return base.ToString()+ "\n Produttore: "+produttore+ "\n";
        }
    }
}
