using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketAppV0._2.Controller;
using BusTicketAppV0._2.Model.Entity;

namespace BusTicketAppV0._2.View
{
    public partial class EntryRute : Form
    {
        public delegate void CreateUpdateEventHandler(Rute rute);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private ControllerRute controller;

        private bool isNewData = true;

        private Rute rute;
        public EntryRute()
        {
            InitializeComponent();
        }
        public EntryRute(string title, ControllerRute controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public EntryRute(string title, Rute obj, ControllerRute controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            rute = obj;

            txtKotaAsal.Text = rute.Kota_Asal;
            txtKotaTujuan.Text = rute.Kota_Tujuan;
            txtWktKeberangkatan.Text = rute.Waktu_Keberangkatan;
            txtWktKedatangan.Text = rute.Waktu_Kedatangan;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtKotaAsal.Clear();
            txtKotaTujuan.Clear();
            txtWktKeberangkatan.Clear();
            txtWktKedatangan.Clear();
            txtKotaAsal.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) rute = new Rute();
            rute.Kota_Asal = txtKotaAsal.Text;
            rute.Kota_Tujuan = txtKotaTujuan.Text;
            rute.Waktu_Keberangkatan = txtWktKeberangkatan.Text;
            rute.Waktu_Kedatangan = txtWktKedatangan.Text;
            int result = 0;
            if (isNewData)
            {
                result = controller.Create(rute);
                if (result > 0)
                {
                    OnCreate(rute);

                    txtKotaAsal.Clear();
                    txtKotaTujuan.Clear();
                    txtWktKeberangkatan.Clear();
                    txtWktKedatangan.Clear();
                    txtKotaAsal.Focus();
                }
            }
            else
            {
                result = controller.Update(rute);
                if (result > 0)
                {
                    OnUpdate(rute);
                    this.Close();
                }
            }
        }
    }
}
