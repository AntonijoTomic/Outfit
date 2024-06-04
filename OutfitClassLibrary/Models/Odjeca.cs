using OutfitClassLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutfitClassLibrary.Models
{
    public abstract class Odjeca : Artikl
    {
        public int Id { get; set; }
        public VelicinaEnum Velicina { get; set; }
        public Odjeca(int id, string naziv, BojaEnum boja, VelicinaEnum velicina) : base(naziv, boja)
        {
            Velicina = velicina;
            Id = id;
        }

       
    }
}
