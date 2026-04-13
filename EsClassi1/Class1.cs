using System;
using System.Collections.Generic;
using System.Text;
namespace EsClassi1
{
    public class Libro
    {
        private string titolo;
        private Autore autore;
        private int anno;
        private int pagine;

        public string Titolo {
            get { 
                return titolo;
            }
        }
        public Autore Autore { 
            get { 
                return autore;
            }
        }
        public int Anno { 
            get {
                return anno;
            }
        }
        public int Pagine {
            get { 
                return pagine; 
            }
        }

        public Libro(string titolo, Autore autore, int anno, int pagine)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.anno = anno;
            this.pagine = pagine;
            
        }

        public string Info()
        {
            return $"'{this.titolo}' di {this.autore.Info()}, (Anno {this.anno})";
        }
    }
}