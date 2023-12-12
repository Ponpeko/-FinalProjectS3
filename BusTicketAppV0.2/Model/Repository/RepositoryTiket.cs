using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Context;
using System.Data;

namespace BusTicketAppV0._2.Model.Repository
{
    public class RepositoryTiket
    {
        private SQLiteConnection _conn;
        public RepositoryTiket(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<Rute> ReadIdRute(string idRute)
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"select ID_Rute, Kota_Asal, Kota_Tujuan, Waktu_Keberangkatan, Waktu_Kedatangan from Rute where ID_Rute like @ID_Rute order by ID_Rute";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Rute", string.Format("{0}", idRute));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Rute rute = new Rute();
                            rute.IdRute = dtr["ID_Rute"].ToString();
                            rute.Kota_Asal = dtr["Kota_Asal"].ToString();
                            rute.Kota_Tujuan = dtr["Kota_Tujuan"].ToString();
                            rute.Waktu_Keberangkatan = dtr["Waktu_Keberangkatan"].ToString();
                            rute.Waktu_Kedatangan = dtr["Waktu_Kedatangan"].ToString();

                            list.Add(rute);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return list;
        }

        public List<Bus> ReadIdBus(string idBus)
        {
            List<Bus> list = new List<Bus>();
            try
            {
                string sql = @"select ID_Bus, Nama_Bus, Jenis_Bus, Kapasitas from Bus where ID_Bus like @ID_Bus order by ID_Bus";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Bus", string.Format("{0}", idBus));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Bus bus = new Bus();
                            bus.IdBus = dtr["ID_Bus"].ToString();
                            bus.NamaBus = dtr["Nama_Bus"].ToString();
                            bus.JenisBus = dtr["Jenis_Bus"].ToString();
                            bus.Kapasitas = dtr["Kapasitas"].ToString();

                            list.Add(bus);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return list;
        }

        public List<Penumpang> ReadIdPenumpang(string idPenumpang)
        {
            List<Penumpang> list = new List<Penumpang>();
            try
            {
                string sql = @"select ID_Penumpang, Nama, No_Kursi from Penumpang where ID_Penumpang like @ID_Penumpang order by ID_Penumpang";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Penumpang", string.Format("{0}", idPenumpang));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penumpang penumpang = new Penumpang();
                            penumpang.Nama = dtr["Nama"].ToString();
                            penumpang.NoKursi = dtr["No_Kursi"].ToString();
                            penumpang.IdPenumpang = dtr["ID_Penumpang"].ToString();
                            list.Add(penumpang);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return list;
        }

        public int CreateTiket(Tiket tiket)
        {
            int result = 0;
            string sql = @"insert into Tiket (Harga, Jumlah_Beli, Metode_Pembayaran) values (@Harga, @Jumlah_Beli, @Metode_Pembayaran)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Harga", tiket.Harga);
                cmd.Parameters.AddWithValue("@Jumlah_Beli", tiket.Jumlah_Beli);
                cmd.Parameters.AddWithValue("@Metode_Pembayaran", tiket.Metode_Pembayaran);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Tiket> ReadTiket(string idTiket)
        {
            List<Tiket> list = new List<Tiket>();
            try
            {
                string sql = @"select Harga, Jumlah_Beli, Metode_Pembayaran from Tiket where ID_Tiket like ID_Tiket";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@ID_Tiket", string.Format("{0}", idTiket));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Tiket tiket = new Tiket();
                            tiket.Harga = dtr["Harga"].ToString();
                            tiket.Jumlah_Beli = dtr["Jumlah_Beli"].ToString();
                            tiket.Metode_Pembayaran = dtr["Metode_Pembayaran"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }
            return list;
        }
    }
}
