using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    class Carrello
    {
        private string _id;
        string[] prodotto = new string[100];
        private int counter;

        public Carrello(string id)
        {
            Id = id;
        }

        public string Id
        {
             get { return _id; }
             set { _id = value; }
        }
        /*
        public void setCounter(int conta)
        {
            this.counter = conta;
        }
        public int getCounter()
        {
            return counter;
        }
        */
        public void Aggiungi(Prodotto p)
        {
            p.Id = prodotto[counter];
            counter++;
            
        }
        public void Rimuovi(Prodotto p)
        {
            p.Id = prodotto[counter];
            counter--;
            
        }

        public int getProdotti()
        {
            return counter;
        }
        public void Svuota()
        {
            counter = 0;
            
        }
    }
}
