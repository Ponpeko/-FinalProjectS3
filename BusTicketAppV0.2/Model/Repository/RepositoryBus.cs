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
    public class RepositoryBus
    {
        private SQLiteConnection _conn;

        public RepositoryBus(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Bus bus)
        {
            int result = 0;
            string sql = @"insert into Bus (Nama_Bus, Jenis_Bus, Kapasitas) values (@Nama_Bus, @Jenis_Bus, @Kapasitas)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama_Bus", bus.NamaBus);
                cmd.Parameters.AddWithValue("@Jenis_Bus", bus.JenisBus);
                cmd.Parameters.AddWithValue("@Kapasitas", bus.Kapasitas);
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

        public int Update(Bus bus)
        {
            int result = 0;
            string sql = @"update Bus set Jenis_Bus = @Jenis_Bus, Kapasitas = @Kapasitas, Nama_Bus = @Nama_Bus where ID_Bus = @ID_Bus";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Jenis_Bus", bus.JenisBus);
                cmd.Parameters.AddWithValue("@Kapasitas", bus.Kapasitas);
                cmd.Parameters.AddWithValue("@Nama_Bus", bus.NamaBus);
                cmd.Parameters.AddWithValue("@ID_Bus", bus.IdBus);
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

        public int Delete(Bus bus)
        {
            int result = 0;
            string sql = @"delete from Bus where Nama_Bus = @Nama_Bus";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama_Bus", bus.NamaBus);
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

        public List<Bus> ReadAll()
        {
            List<Bus> list = new List<Bus>();
            try
            {
                string sql = @"select ID_Bus, Nama_Bus, Jenis_Bus, Kapasitas from Bus order by ID_Bus";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
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
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<Bus> ReadByBus(string cari)
        {
            List<Bus> list = new List<Bus>();
            try
            {
                string sql = @"select ID_Bus, Nama_Bus, Jenis_Bus, Kapasitas from Bus where Jenis_Bus like @Jenis_Bus order by ID_Bus";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Jenis_Bus", string.Format("%{0}%", cari));

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
                System.Diagnostics.Debug.Print("ReadByBus error: {0}", ex.Message);
            }
            return list;
        }
    }
}
