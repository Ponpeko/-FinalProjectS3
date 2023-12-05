using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Context;

namespace BusTicketAppV0._2.Model.Repository
{
    public class RepositoryRute
    {
        private SQLiteConnection _conn;

        public RepositoryRute(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Rute rute)
        {
            int result = 0;
            string sql = @"insert into Rute (Kota_Asal, Kota_Tujuan, Waktu_Keberangkatan, Waktu_Kedatangan) values (@Kota_Asal, @Kota_Tujuan, @Waktu_Keberangkatan, @Waktu_Kedatangan)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kota_Asal", rute.Kota_Asal);
                cmd.Parameters.AddWithValue("@Kota_Tujuan", rute.Kota_Tujuan);
                cmd.Parameters.AddWithValue("@Waktu_Keberangkatan", rute.Waktu_Keberangkatan);
                cmd.Parameters.AddWithValue("@Waktu_Kedatangan", rute.Waktu_Kedatangan);
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

        public int Update(Rute rute)
        {
            int result = 0;
            string sql = @"update Rute set Kota_Tujuan = @Kota_Tujuan, Waktu_Keberangkatan = @Waktu_Keberangkatan, Waktu_Kedatangan = @Waktu_Kedatangan, Kota_Asal = @Kota_Asal where ID_Rute = @ID_Rute";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kota_Asal", rute.Kota_Asal);
                cmd.Parameters.AddWithValue("@Kota_Tujuan", rute.Kota_Tujuan);
                cmd.Parameters.AddWithValue("@Waktu_Keberangkatan", rute.Waktu_Keberangkatan);
                cmd.Parameters.AddWithValue("@Waktu_Kedatangan", rute.Waktu_Kedatangan);
                cmd.Parameters.AddWithValue("@ID_Rute", rute.IdRute);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Rute rute)
        {
            int result = 0;
            string sql = @"delete from Rute where Kota_Asal = @Kota_Asal";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Kota_Asal", rute.Kota_Asal);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;

        }

        public List<Rute> ReadAll()
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"select ID_Rute, Kota_Asal, Kota_Tujuan, Waktu_Keberangkatan, Waktu_Kedatangan from Rute order by ID_Rute";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
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
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<Rute> ReadByKota(string kota)
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"select ID_Rute, Kota_Asal, Kota_Tujuan, Waktu_Keberangkatan, Waktu_Kedatangan from Rute where Kota_Tujuan like @Kota_Tujuan order by ID_Rute";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Kota_Tujuan", string.Format("%{0}%", kota));

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
    }
}
