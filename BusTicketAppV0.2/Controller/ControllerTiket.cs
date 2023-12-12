using BusTicketAppV0._2.Model.Context;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketAppV0._2.Controller
{
    public class ControllerTiket
    {
        private SQLiteConnection _conn;
        RepositoryTiket _repository;

        public List<Rute> ReadIdRute(string idRute)
        {
            List<Rute> list = new List<Rute>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryTiket(context);

                list = _repository.ReadIdRute(idRute);
            }
            return list;
        }

        public List<Bus> ReadIdBus(string idBus)
        {
            List<Bus> list = new List<Bus>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryTiket(context);

                list = _repository.ReadIdBus(idBus);
            }
            return list;
        }

        public List<Penumpang> ReadIdPenumpang(string idPenumpang)
        {
            List<Penumpang> list = new List<Penumpang>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryTiket(context);

                list = _repository.ReadIdPenumpang(idPenumpang);
            }
            return list;
        }
        
        public int CreateTiket(Tiket tiket)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tiket.Jumlah_Beli))
            {
                MessageBox.Show("Masukkan jumlah beli !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tiket.Metode_Pembayaran))
            {
                MessageBox.Show("Pilih metode pembayaran !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if(string.IsNullOrEmpty(tiket.Harga))
            {
                MessageBox.Show("Masukkan harga tiket !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryTiket(context);

                result = _repository.CreateTiket(tiket);
            }

            if (result > 0)
            {
                MessageBox.Show("Tiket dibuat !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Gagal membuat tiket !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        public List<Tiket> ReadTiket(string idTiket)
        {
            List<Tiket> list = new List<Tiket>();

            using (DbContext context = new DbContext())
            {
                _repository = new RepositoryTiket(context);

                list = _repository.ReadTiket(idTiket);
            }
            return list;
        }
    }
}
