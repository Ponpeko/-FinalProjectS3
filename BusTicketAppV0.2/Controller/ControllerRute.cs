using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Context;
using BusTicketAppV0._2.Model.Repository;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BusTicketAppV0._2.Controller
{
    public class ControllerRute
    {
        private SQLiteConnection _conn;

        RepositoryRute _repository;
        public int Create(Rute rute)
        {
            int result = 0;

            if (string.IsNullOrEmpty(rute.Kota_Asal))
            {
                MessageBox.Show("Kota Asal harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.Kota_Tujuan))
            {
                MessageBox.Show("Kota Tujuan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.Waktu_Keberangkatan))
            {
                MessageBox.Show("Waktu Keberangkatan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.Waktu_Kedatangan))
            {
                MessageBox.Show("Waktu Kedatangan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryRute(context);

                result = _repository.Create(rute);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Rute berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Rute gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Rute rute)
        {
            int result = 0;
            if (string.IsNullOrEmpty(rute.Kota_Asal))
            {
                MessageBox.Show("Kota Asal harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.Kota_Tujuan))
            {
                MessageBox.Show("Kota Tujuan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.Waktu_Keberangkatan))
            {
                MessageBox.Show("Waktu Keberangkatan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.Waktu_Kedatangan))
            {
                MessageBox.Show("Waktu Kedatangan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryRute(context);

                result = _repository.Update(rute);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Rute berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Rute gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(Rute rute)
        {
            int result = 0;
            if (string.IsNullOrEmpty(rute.Kota_Asal))
            {
                MessageBox.Show("Kota Asal harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryRute(context);
                result = _repository.Delete(rute);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Rute berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Rute gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Rute> ReadAll()
        {
            List<Rute> list = new List<Rute>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryRute(context);

                list = _repository.ReadAll();
            }
            return list;

        }

        public List<Rute> ReadByKota(string kota)
        {
            List<Rute> list = new List<Rute>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryRute(context);

                list = _repository.ReadByKota(kota);
            }
            return list;
        }
    }
}
