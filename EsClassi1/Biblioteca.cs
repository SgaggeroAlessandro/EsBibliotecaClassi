using System;
using System.Collections.Generic;
using System.Text;

namespace EsClassi1
{
    public class Biblioteca
    {
        private string nome;
        private Autore[] elencoAutori;
        private Libro[] elencoLibri;
        private int numeroAutori = 0;
        private int numeroLibri = 0;

        public Autore[] ElencoAutori
        {
            get
            {
                return elencoAutori;
            }
        }
       public Libro[] ElencoLibri
        {
            get
            {
                return elencoLibri;
            }
        }

        public int TotalePagine
        {
            get
            {
                int totale = 0;
                for (int i = 0; i < numeroLibri; i++)
                {
                    totale += elencoLibri[i].Pagine;
                }
                   
                return totale;
            }
        }
        public Biblioteca(string nome)
        {
            this.nome = nome;
            this.elencoAutori = new Autore[100];
            this.elencoLibri = new Libro[100];
        }
         public string info()
        {
            return $"La biblioteca '{this.nome}' ha {this.elencoAutori} autori e {this.elencoLibri} libri.";
        }

        public int AggiungiAutore(Autore nuovoAutore)
        {
            elencoAutori[numeroAutori] = nuovoAutore;
            numeroAutori++;
            return numeroAutori;
        }

        public int AggiungiLibro(Libro nuovoLibro)
        {
            elencoLibri[numeroLibri] = nuovoLibro;
            numeroLibri++;
            return numeroLibri;
        }

        public Autore[] AutoriInAnno(int anno)
        {
            return Array.FindAll(this.elencoAutori, autore => autore != null && autore.Nascita.Year == anno);
        }

        public string Info()
        {
            return $"La biblioteca '{this.nome}' ha {numeroAutori} autori e {numeroLibri} libri.";
        }

        public string LibriInAnno(int anno)
        {
            string risultato = "";
            for (int i = 0; i < numeroLibri; i++)
            {


                if (elencoLibri[i].Anno == anno)
                {
                    risultato += elencoLibri[i].Info() + "\n";
                }
            }
           if(risultato == "")
           {
               return $"Nessun libro trovato nell'anno {anno}";
           }
           else
           {
               return $"Libri pubblicati nell'anno {anno}:\n{risultato}";
           }
        }
    }
}
