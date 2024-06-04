using System;
using System.Collections.Generic;

namespace OutfitClassLibrary.Models
{
    public class Korisnik
    {
        public string Name { get; set; }

        List<Artikl> Outfit {  get; set; }
        public Korisnik(string name)
        {
            Outfit = new List<Artikl>();
            Name = name;
        }

        public void DodajArtikl(Artikl a)
        {
            Outfit.Add(a);
        }

        public void PrikaziOutfit()
        {
            Console.Clear();
            Console.WriteLine("Vas odabir je:");
            foreach(Artikl a in Outfit)
            {
                a.Ispisi();
            }
        }
    }
}
