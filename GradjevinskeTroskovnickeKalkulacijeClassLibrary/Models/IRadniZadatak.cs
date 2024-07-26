using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradjevinskeTroskovnickeKalkulacijeClassLibrary.Models
{
    internal interface IRadniZadatak
    {
        public string Kvalifikacija { get; set; }
        public string OpisZadatka { get; set; }
        public decimal NormiraniUtrosak { get; set; }
        public string JedinicaMjere { get; set; }
        public decimal BrutoSatnica { get; set; }
        public decimal BrojRadnika { get; set; }
    }
}
