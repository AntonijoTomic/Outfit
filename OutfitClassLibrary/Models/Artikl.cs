
using OutfitClassLibrary.Enumerations;
namespace OutfitClassLibrary.Models
{
    public abstract class Artikl
    {
        public string Naziv { get; set; }
        public BojaEnum Boja { get; set; }

        public Artikl(string naziv, BojaEnum boja)
        {
            Naziv = naziv;
            Boja = boja;
        }

        public abstract void Ispisi();
    }
}
