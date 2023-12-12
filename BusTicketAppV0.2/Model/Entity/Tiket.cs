using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketAppV0._2.Model.Entity
{
    public class Tiket
    {
        public string IdTiket { get; set; }
        public string Harga { get; set; }
        public string Jumlah_Beli { get; set; }
        public string Metode_Pembayaran { get; set; }
    }
}
