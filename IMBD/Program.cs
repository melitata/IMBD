using System;
using System.Collections.Generic;

class Film
{
    public double ImdbPuani { get; set; }
    public string Isim { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmler = new List<Film>();
        string devam;

        do
        {
            Console.Write("Film ismini girin: ");
            string isim = Console.ReadLine();
            Console.Write("IMDb puanını girin: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.Write("Geçersiz giriş! Lütfen geçerli bir IMDb puanı girin: ");
            }
            filmler.Add(new Film(isim, imdbPuani));
            Console.Write("Başka bir film eklemek ister misiniz? (E/H): ");
            devam = Console.ReadLine().ToUpper();

        } while (devam == "E");
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
        }
        Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }
        }
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        foreach (var film in filmler)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }
        }
    }
}
