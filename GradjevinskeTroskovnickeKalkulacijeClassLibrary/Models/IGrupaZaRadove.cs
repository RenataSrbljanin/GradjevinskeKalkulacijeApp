using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradjevinskeTroskovnickeKalkulacijeClassLibrary.Models
{
    internal interface IGrupaZaRadove
    {
        public List<IRadniZadatak> radovi { get; set; }
        public decimal TrosakGrupe { get; set; }
    }
}
