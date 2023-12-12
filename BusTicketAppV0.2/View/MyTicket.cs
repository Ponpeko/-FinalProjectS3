using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketAppV0._2.Model.Entity;
using BusTicketAppV0._2.Model.Repository;
using BusTicketAppV0._2.Controller;

namespace BusTicketAppV0._2.View
{
    public partial class MyTicket : Form
    {
        private List<Rute> listOfRute = new List<Rute>();
        private List<Bus> listOfBus = new List<Bus>();
        private List<Penumpang> listOfPenumpang = new List<Penumpang>();
        private List<Tiket> listOfTiket = new List<Tiket>();

        private ControllerTiket controller;

        public MyTicket(string idRute, string idBus, string idPenumpang, string idTiket)
        {
            InitializeComponent();
            controller = new ControllerTiket();

            TampilkanData(idRute, idBus, idPenumpang, idTiket);
        }

        private void TampilkanData(string idRute, string idBus, string idPenumpang, string idTiket)
        {
            var resultRute = controller.ReadIdRute(idRute);
            listOfRute = resultRute.ToList();

            var resultBus = controller.ReadIdBus(idBus);
            listOfBus = resultBus.ToList();

            var resultPenumpang = controller.ReadIdPenumpang(idPenumpang);
            listOfPenumpang = resultPenumpang.ToList();

            var resultTiket = controller.ReadTiket(idTiket);
            listOfTiket = resultTiket.ToList();
            

            foreach (var rute in listOfRute)
            {
                lblKotaAsal.Text = rute.Kota_Asal.ToString();
                lblKotaTujuan.Text = rute.Kota_Tujuan.ToString();
                lblWktKeberangkatan.Text = rute.Waktu_Keberangkatan.ToString();
                lblWktKedatangan.Text = rute.Waktu_Kedatangan.ToString();
            }

            foreach (var bus in listOfBus)
            {
                lblNamaBus.Text = bus.NamaBus.ToString();
                lblJenisBus.Text = bus.JenisBus.ToString();
            }
            
            foreach (var penumpang in listOfPenumpang)
            {
                lblNoKursi.Text = penumpang.NoKursi.ToString();
                lblNama.Text = penumpang.Nama.ToString();
                lblIdPenumpang.Text = "0000" + penumpang.IdPenumpang.ToString();
            }

            foreach (var tiket in listOfTiket)
            {
                int harga = int.Parse(tiket.Harga);
                int jumlahBeli = int.Parse(tiket.Jumlah_Beli);
                int totalBayar = harga * jumlahBeli;


                lblIdTiket.Text = tiket.IdTiket.ToString();
                lblMetodePembayaran.Text = tiket.Metode_Pembayaran.ToString();
                lblTotalBayar.Text = totalBayar.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWktKeberangkatan_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MyTicket_Load(object sender, EventArgs e)
        {

        }

        private void lblTotalBayar_Click(object sender, EventArgs e)
        {

        }
    }
}
