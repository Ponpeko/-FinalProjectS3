using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketAppV0._2.Model.Entity
{
    public class Rute
    {
        public string IdRute { get; set; }
        public string Kota_Asal { get; set; }
        public string Kota_Tujuan { get; set; }
        public string Waktu_Keberangkatan { get; set; }
        public string Waktu_Kedatangan { get; set; }
    }
}
