using OutfitClassLibrary.Enumerations;
using System;

namespace OutfitClassLibrary.Models
{
    public class Tenisice : Obuca
    {
        public Tenisice(int id, string naziv, BojaEnum boja, VelicinaObuceEnum velicina) : base(id, naziv, boja, velicina)
        {
        }

        public override void Ispisi()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Boja.ToString());
            Console.WriteLine($"{Id} Tenisice: {Naziv}, Boja: {Boja}, Veličina: {Velicina}");
            Console.ResetColor();
        }
    
    }
}
