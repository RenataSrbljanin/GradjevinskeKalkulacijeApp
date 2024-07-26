using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradjevinskeTroskovnickeKalkulacijeClassLibrary.Models
{
    internal interface IStavka
    {
        public string Opis { get; set; }
        public string Jedinica { get; set; }
        public decimal Kolicina { get; set; }
        public decimal CijenaPoJedinici { get; set; }
        public decimal UkupnoCijena { get; set; }
        public List<IVrstaMaterijala> materijali { get; set; }
        public List<IGrupaZaRadove> radneGrupe { get; set; }
    }
}
