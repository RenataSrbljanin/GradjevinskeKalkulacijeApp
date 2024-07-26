using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradjevinskeTroskovnickeKalkulacijeClassLibrary.Models
{
    internal interface IVrstaMaterijala
    {
        public string NazivMaterijala { get; set; }
        public string NormiranaKolicina { get; set; }
        public string JedinicaMjere { get; set; }
        public decimal CijenaPoJediniciMjere { get; set; }
        public decimal UkupnaCijena { get; set; }
    }
}
