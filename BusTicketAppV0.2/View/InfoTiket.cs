using BusTicketAppV0._2.Controller;
using BusTicketAppV0._2.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketAppV0._2.View
{
    public partial class InfoTiket : Form
    {
        private List<Bus> listOfBus = new List<Bus>();
        private ControllerBus controllerBus;

        private List<Rute> listOfRute = new List<Rute>();
        private ControllerRute controllerRute;

        private List<Penumpang> listOfPenumpang = new List<Penumpang>();
        private ControllerPenumpang controllerPenumpang;

        public InfoTiket()
        {
            InitializeComponent();

            controllerBus = new ControllerBus();
            controllerRute = new ControllerRute();
            controllerPenumpang = new ControllerPenumpang();

            InisialisasiListViewBus();
            LoadDataBus();

            InisialisasiListViewRute();
            LoadDataRute();

            InisialisasiListViewPenumpang();
            LoadDataPenumpang();
        }

        private void InisialisasiListViewBus()
        {
            lvwBus.View = System.Windows.Forms.View.Details;
            lvwBus.FullRowSelect = true;
            lvwBus.GridLines = true;
            lvwBus.Columns.Add("ID.", 30, HorizontalAlignment.Center);
            lvwBus.Columns.Add("Nama Bus", 110, HorizontalAlignment.Center);
            lvwBus.Columns.Add("Jenis Bus", 100, HorizontalAlignment.Center);
            lvwBus.Columns.Add("Kapasitas", 100, HorizontalAlignment.Center);
        }
        private void LoadDataBus()
        {
            lvwBus.Items.Clear();

            listOfBus = controllerBus.ReadAll();

            foreach (var bus in listOfBus)
            {

                var item = new ListViewItem(bus.IdBus);
                item.SubItems.Add(bus.NamaBus);
                item.SubItems.Add(bus.JenisBus);
                item.SubItems.Add(bus.Kapasitas);

                lvwBus.Items.Add(item);
            }
        }

        private void InisialisasiListViewRute()
        {
            lvwRute.View = System.Windows.Forms.View.Details;
            lvwRute.FullRowSelect = true;
            lvwRute.GridLines = true;
            lvwRute.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Kota Asal", 100, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Kota Tujuan", 100, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Waktu Keberangkatan", 150, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Waktu Kedatangan", 150, HorizontalAlignment.Center);
        }
        private void LoadDataRute()
        {
            lvwRute.Items.Clear();

            listOfRute = controllerRute.ReadAll();

            foreach (var rute in listOfRute)
            {
                var item = new ListViewItem(rute.IdRute);
                item.SubItems.Add(rute.Kota_Asal);
                item.SubItems.Add(rute.Kota_Tujuan);
                item.SubItems.Add(rute.Waktu_Keberangkatan);
                item.SubItems.Add(rute.Waktu_Kedatangan);

                lvwRute.Items.Add(item);
            }
        }

        private void InisialisasiListViewPenumpang()
        {
            lvwPenumpang.View = System.Windows.Forms.View.Details;
            lvwPenumpang.FullRowSelect = true;
            lvwPenumpang.GridLines = true;
            lvwPenumpang.Columns.Add("ID.", 30, HorizontalAlignment.Center);
            lvwPenumpang.Columns.Add("Nama", 130, HorizontalAlignment.Left);
            lvwPenumpang.Columns.Add("No. Kontak", 110, HorizontalAlignment.Center);
            lvwPenumpang.Columns.Add("Gender", 50, HorizontalAlignment.Center);
            lvwPenumpang.Columns.Add("No. Kursi", 80, HorizontalAlignment.Center);
        }
        private void LoadDataPenumpang()
        {
            lvwPenumpang.Items.Clear();

            listOfPenumpang = controllerPenumpang.ReadAll();

            foreach (var penumpang in listOfPenumpang)
            {
                var item = new ListViewItem(penumpang.IdPenumpang);
                item.SubItems.Add(penumpang.Nama);
                item.SubItems.Add(penumpang.NoKontak);
                item.SubItems.Add(penumpang.Gender);
                item.SubItems.Add(penumpang.NoKursi);

                lvwPenumpang.Items.Add(item);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
