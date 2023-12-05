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
    public class ControllerPenumpang
    {
        private SQLiteConnection _conn;

        RepositoryPenumpang _repository;

        public int Create(Penumpang penumpang)
        {
            int result = 0;

            if (string.IsNullOrEmpty(penumpang.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penumpang.NoKontak))
            {
                MessageBox.Show("Nomor harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penumpang.Gender))
            {
                MessageBox.Show("Jenis Kelamin harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penumpang.NoKursi))
            {
                MessageBox.Show("Nomor Kursi harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryPenumpang(context);

                result = _repository.Create(penumpang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Penumpang berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Penumpang gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int Update(Penumpang penumpang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(penumpang.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penumpang.NoKontak))
            {
                MessageBox.Show("Nomor Kontak harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penumpang.Gender))
            {
                MessageBox.Show("Jenis Kelamin harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(penumpang.NoKursi))
            {
                MessageBox.Show("Nomor Kursi harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryPenumpang(context);

                result = _repository.Update(penumpang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Penumpang berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Penumpang gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Penumpang penumpang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(penumpang.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryPenumpang(context);
                result = _repository.Delete(penumpang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Penumpang berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Penumpang gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public List<Penumpang> ReadAll()
        {
            List<Penumpang> list = new List<Penumpang>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryPenumpang(context);

                list = _repository.ReadAll();
            }
            return list;

        }
        public List<Penumpang> ReadByNama(string nama)
        {
            List<Penumpang> list = new List<Penumpang>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryPenumpang(context);

                list = _repository.ReadByNama(nama);
            }
            return list;
        }
    }
}
