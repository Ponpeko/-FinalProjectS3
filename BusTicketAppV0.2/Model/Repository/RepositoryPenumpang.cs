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
    public class RepositoryPenumpang
    {
        private SQLiteConnection _conn;

        public RepositoryPenumpang(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Penumpang penumpang)
        {
            int result = 0;
            string sql = @"insert into Penumpang (Nama, No_Kontak, No_Kursi, Gender ) values (@Nama, @No_Kontak, @No_Kursi, @Gender)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", penumpang.Nama);
                cmd.Parameters.AddWithValue("@No_Kontak", penumpang.NoKontak);
                cmd.Parameters.AddWithValue("@Gender", penumpang.Gender);
                cmd.Parameters.AddWithValue("@No_Kursi", penumpang.NoKursi);
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

        public int Update(Penumpang penumpang)
        {
            int result = 0;
            string sql = @"update Penumpang set Nama = @Nama, No_Kontak = @No_Kontak, Gender = @Gender, No_Kursi = @No_Kursi where ID_Penumpang = @ID_Penumpang";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", penumpang.Nama);
                cmd.Parameters.AddWithValue("@No_Kontak", penumpang.NoKontak);
                cmd.Parameters.AddWithValue("@Gender", penumpang.Gender);
                cmd.Parameters.AddWithValue("@No_Kursi", penumpang.NoKursi);
                cmd.Parameters.AddWithValue("@ID_Penumpang", penumpang.IdPenumpang);
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

        public int Delete(Penumpang penumpang)
        {
            int result = 0;
            string sql = @"delete from Penumpang where Nama = @Nama";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", penumpang.Nama);
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

        public List<Penumpang> ReadAll()
        {
            List<Penumpang> list = new List<Penumpang>();
            try
            {
                string sql = @"select ID_Penumpang, Nama, No_Kontak, No_Kursi, Gender from Penumpang order by ID_Penumpang";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penumpang penumpang = new Penumpang();
                            penumpang.Nama = dtr["Nama"].ToString();
                            penumpang.NoKontak = dtr["No_Kontak"].ToString();
                            penumpang.Gender = dtr["Gender"].ToString();
                            penumpang.NoKursi = dtr["No_Kursi"].ToString();
                            penumpang.IdPenumpang = dtr["ID_Penumpang"].ToString();

                            list.Add(penumpang);
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
        public List<Penumpang> ReadByNama(string cari)
        {
            List<Penumpang> list = new List<Penumpang>();
            try
            {
                string sql = @"select ID_Penumpang, Nama, No_Kontak, Gender, No_Kursi from Penumpang where Nama like @Nama order by Nama";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", string.Format("%{0}%", cari));

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penumpang penumpang = new Penumpang();
                            penumpang.Nama = dtr["Nama"].ToString();
                            penumpang.NoKontak = dtr["No_Kontak"].ToString();
                            penumpang.NoKursi = dtr["No_Kursi"].ToString();
                            penumpang.Gender = dtr["Gender"].ToString();
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
    }
}
