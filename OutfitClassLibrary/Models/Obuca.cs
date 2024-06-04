using OutfitClassLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutfitClassLibrary.Models
{
    public abstract class Obuca : Artikl
    {
        public int Id { get; set; }
       
        public VelicinaObuceEnum Velicina { get; set; }
        public Obuca(int id,string naziv, BojaEnum boja, VelicinaObuceEnum velicina) : base(naziv, boja)
        {
            Id = id;
            Velicina = velicina;
        }
    }
}
