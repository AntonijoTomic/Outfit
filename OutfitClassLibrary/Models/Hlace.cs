using OutfitClassLibrary.Enumerations;
using System;

namespace OutfitClassLibrary.Models
{
    public class Hlace : Odjeca
    {
        public Hlace(int id, string naziv, BojaEnum boja, VelicinaEnum velicina) : base(id, naziv, boja, velicina)
        {
        }

        public override void Ispisi()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Boja.ToString());
            Console.WriteLine($"{Id} Hlace: {Naziv}, Boja: {Boja}, Veličina: {Velicina}");
            Console.ResetColor();
        }
    }
}
