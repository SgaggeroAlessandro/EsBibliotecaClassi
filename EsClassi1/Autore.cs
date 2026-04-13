using System;
using System.Collections.Generic;
using System.Text;
namespace EsClassi1
{
    public class Autore
    {
        private string cognome;
        private string nome;
        private char sesso;
        private DateOnly nascita;
        private List<Libro> libri;

        public string Nome {
            get {
                return nome; 
            }
        }
        public string Cognome { 
            get { return cognome; 
            }
        }
        public DateOnly Nascita {
            get { 
                return nascita; 
            }
        }
        public List<Libro> ElencoLibri { 
            get {
                return libri; 
            }
        }

        public Autore(string cognome, string nome, char sesso, DateOnly nascita)
        {
            this.cognome = cognome;
            this.nome = nome;
            this.sesso = sesso;
            this.nascita = nascita;
            this.libri = new List<Libro>();
        }

        public string Info()
        {
            return $"{this.nome} {this.cognome} ({this.sesso}), nato il {this.nascita.ToShortDateString()}";
        }

        public int Aggiungi(Libro nuovoLibro)
        {
            libri.Add(nuovoLibro);
            return this.libri.Count;
        }
    }
}