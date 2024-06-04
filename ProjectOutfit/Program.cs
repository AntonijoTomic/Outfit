using OutfitClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dobrodosli!\nUnesite vase ime: ");
            Korisnik k1 = new Korisnik(Console.ReadLine());



            //punim bazu odjece
            Majica m1 = new Majica(1,"Nike majica", OutfitClassLibrary.Enumerations.BojaEnum.White, OutfitClassLibrary.Enumerations.VelicinaEnum.M);
            Majica m2 = new Majica(2,"Nike majica", OutfitClassLibrary.Enumerations.BojaEnum.Black, OutfitClassLibrary.Enumerations.VelicinaEnum.S);
            Majica m3 = new Majica(3,"Nike majica", OutfitClassLibrary.Enumerations.BojaEnum.Blue, OutfitClassLibrary.Enumerations.VelicinaEnum.XS);
            Majica m4 = new Majica(4,"Nike majica", OutfitClassLibrary.Enumerations.BojaEnum.Blue, OutfitClassLibrary.Enumerations.VelicinaEnum.XXL);

            Hlace h1 = new Hlace(5,"Traperice", OutfitClassLibrary.Enumerations.BojaEnum.Blue, OutfitClassLibrary.Enumerations.VelicinaEnum.XXL);
            Hlace h2 = new Hlace(6,"Traperice", OutfitClassLibrary.Enumerations.BojaEnum.Black, OutfitClassLibrary.Enumerations.VelicinaEnum.M);
            Hlace h3 = new Hlace(7,"Traperice", OutfitClassLibrary.Enumerations.BojaEnum.Red, OutfitClassLibrary.Enumerations.VelicinaEnum.S);
            Hlace h4 = new Hlace(8,"Traperice", OutfitClassLibrary.Enumerations.BojaEnum.Black, OutfitClassLibrary.Enumerations.VelicinaEnum.XXL);

            List<Odjeca> odjeca = new List<Odjeca> { m1, m2, m3, m4, h1, h2, h3, h4 };
            Tenisice t1 = new Tenisice(1,"Nike airMAX", OutfitClassLibrary.Enumerations.BojaEnum.Red, OutfitClassLibrary.Enumerations.VelicinaObuceEnum.Broj43);
            Tenisice t2 = new Tenisice(2,"Nike airMAX", OutfitClassLibrary.Enumerations.BojaEnum.Green, OutfitClassLibrary.Enumerations.VelicinaObuceEnum.Broj43);
            Tenisice t3 = new Tenisice(3,"Nike airMAX", OutfitClassLibrary.Enumerations.BojaEnum.Yellow, OutfitClassLibrary.Enumerations.VelicinaObuceEnum.Broj43);

            Papuce p1 = new Papuce(4,"Natikace", OutfitClassLibrary.Enumerations.BojaEnum.Yellow, OutfitClassLibrary.Enumerations.VelicinaObuceEnum.Broj36);
            Papuce p2 = new Papuce(5,"Natikace", OutfitClassLibrary.Enumerations.BojaEnum.Green, OutfitClassLibrary.Enumerations.VelicinaObuceEnum.Broj43);
            Obuca[] obuca = { t1, t2, t3, p1, p2 };

       
            bool trajeKupnja = true;

            while (trajeKupnja)
            {
                Console.WriteLine($"{k1.Name} Odaberite kategoriju za kupnju:\n1 - Odjeca\n2 - Obuca\n3-kosarica");
                int odabir = Convert.ToInt16(Console.ReadLine());
                if (odabir == 1)
                {
                    Console.WriteLine($"{k1.Name} Odaberite Artikl za kupnju:");

                    foreach (Odjeca o in odjeca)
                    {
                        o.Ispisi();
                    }
                    int odabirOdjece = Convert.ToInt16(Console.ReadLine());

                    foreach (Odjeca o in odjeca)
                    {
                        if (odabirOdjece == o.Id)
                        {
                            k1.DodajArtikl(o);
                        }
                    }

                }
                else if (odabir == 2)
                {
                    Console.WriteLine($"{k1.Name} Odaberite Artikl za kupnju:");

                    foreach (Obuca o in obuca)
                    {
                        o.Ispisi();
                    }
                    int odabirOdjece = Convert.ToInt16(Console.ReadLine());

                    foreach (Obuca o in obuca)
                    {
                        if (odabirOdjece == o.Id)
                        {
                            k1.DodajArtikl(o);
                        }
                    }
                }
                else if(odabir == 3)
                {
                    k1.PrikaziOutfit();
                    trajeKupnja = false;
                }

            }
            Console.ReadLine();
        }
    }
}
