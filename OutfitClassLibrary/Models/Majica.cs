using OutfitClassLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutfitClassLibrary.Models
{
    public class Majica : Odjeca
    {
        public Majica(int id, string naziv, BojaEnum boja, VelicinaEnum velicina) : base(id, naziv, boja, velicina)
        {
        }

        public override void Ispisi()
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Boja.ToString());
            Console.WriteLine($"{Id} Majica: {Naziv}, Boja: {Boja}, Veličina: {Velicina}");
            Console.ResetColor();
        }
    }
}
