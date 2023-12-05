using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketAppV0._2.Model.Entity
{
    public class Pembayaran
    {
        public string Metode_Pembayaran { get; set; }
        public string Jumlah_Pembayaran { get; set; }
        public string Tanggal_Pembayaran { get; set; } 
        public string NoReferensi { get; set; }
    }
}
