using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class AllDipendenti
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public int IdRuolo { get; set; }
        public int IdAziendaAmministrazione {  get; set; }
        public string Stipendio {  get; set; }  
        public string Azienda { get; set; } 
    }
}
