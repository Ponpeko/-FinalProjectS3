using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Context;
using BusTicketAppV0._2.Model.Repository;
using System.Data.SQLite;

namespace BusTicketAppV0._2.Controller
{
    public class ControllerBus
    {
        private SQLiteConnection _conn;

        RepositoryBus _repository;
        public int Create(Bus bus)
        {
            int result = 0;

            if (string.IsNullOrEmpty(bus.NamaBus))
            {
                MessageBox.Show("Nama Bus harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(bus.JenisBus))
            {
                MessageBox.Show("Jenis Bus harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(bus.Kapasitas))
            {
                MessageBox.Show("Pilih Kapasitas Bus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryBus(context);

                result = _repository.Create(bus);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Bus berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Bus gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public int Update(Bus bus)
        {
            int result = 0;
            if (string.IsNullOrEmpty(bus.NamaBus))
            {
                MessageBox.Show("Nama Bus harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(bus.JenisBus))
            {
                MessageBox.Show("Jenis Bus harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(bus.Kapasitas))
            {
                MessageBox.Show("Pilih Kapasitas Bus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryBus(context);

                result = _repository.Update(bus);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Bus berhasil diperbarui !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Bus gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int Delete(Bus bus)
        {
            int result = 0;
            if (string.IsNullOrEmpty(bus.NamaBus))
            {
                MessageBox.Show("Nama Bus harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryBus(context);
                result = _repository.Delete(bus);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Bus berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Bus gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Bus> ReadAll()
        {
            List<Bus> list = new List<Bus>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryBus(context);

                list = _repository.ReadAll();
            }
            return list;

        }

        public List<Bus> ReadByBus(string cari)
        {
            List<Bus> list = new List<Bus>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryBus(context);

                list = _repository.ReadByBus(cari);
            }
            return list;
        }
    }
}
