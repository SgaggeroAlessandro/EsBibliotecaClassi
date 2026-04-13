using EsClassi1;

Biblioteca biblio = new Biblioteca("ITIS Rossi");
int scelta = 0;

while (scelta != 6)
{
    
    Console.WriteLine("1. Aggiungi autore");
    Console.WriteLine("2. Aggiungi libro");
    Console.WriteLine("3. Elenco autori");
    Console.WriteLine("4. Elenco libri");
    Console.WriteLine("5. Cerca per anno");
    Console.WriteLine("6. Esci");
    Console.Write("Scelta: ");
    scelta = int.Parse(Console.ReadLine());

    if (scelta == 1)
    {
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine();
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Sesso (M/F): ");
        char sesso = Console.ReadLine()[0];
        Console.Write("Data di nascita (gg/mm/aaaa): ");
        DateOnly nascita = DateOnly.Parse(Console.ReadLine());
        Autore nuovoAutore = new Autore(cognome, nome, sesso, nascita);
        biblio.AggiungiAutore(nuovoAutore);
        Console.WriteLine("Autore aggiunto.");
    }
    else if (scelta == 2)
    {
        Console.Write("Titolo: ");
        string titolo = Console.ReadLine();
        Console.Write("Anno di pubblicazione: ");
        int anno = int.Parse(Console.ReadLine());
        Console.Write("Numero di pagine: ");
        int pagine = int.Parse(Console.ReadLine());
        Console.Write("Cognome autore: ");
        string cognomeAutore = Console.ReadLine();

        Autore autoreLibro = null;
        foreach (Autore a in biblio.ElencoAutori)
        {
            if (a == null) break;
            if (a.Cognome == cognomeAutore)
            {
                autoreLibro = a;
                break;
            }
        }

        if (autoreLibro == null)
        {
            Console.WriteLine("Autore non trovato.");
        }
        else
        {
            Libro nuovoLibro = new Libro(titolo, autoreLibro, anno, pagine);
            biblio.AggiungiLibro(nuovoLibro);
            Console.WriteLine("Libro aggiunto.");
        }
    }
    else if (scelta == 3)
    {
        Console.WriteLine($"\n{biblio.Info()}\nElenco Autori:");
        foreach (Autore autore in biblio.ElencoAutori)
        {
            if (autore == null) break;
            Console.WriteLine($"- {autore.Info()}\n  libri presenti: {autore.ElencoLibri.Count}");
        }
    }
    else if (scelta == 4)
    {
        int idx = 0;
        Console.WriteLine("\nElenco Libri:");
        foreach (Libro libro in biblio.ElencoLibri)
        {
            if (libro == null) break;
            Console.WriteLine($"{++idx}. {libro.Info()}");
        }
        Console.WriteLine($"Totale pagine: {biblio.TotalePagine}");
    }
    else if (scelta == 5)
    {
        Console.Write("Cerca per anno: ");
        int anno = int.Parse(Console.ReadLine());
        Console.WriteLine(biblio.AutoriInAnno(anno));
        Console.WriteLine(biblio.LibriInAnno(anno));
    }
    else if (scelta == 6)
    {
        Console.WriteLine("Arrivederci!");
    }
    else
    {
        Console.WriteLine("Scelta non valida.");
    }
}