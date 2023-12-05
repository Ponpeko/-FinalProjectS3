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
    public partial class InfoRute : Form
    {
        private List<Rute> listOfRute = new List<Rute>();

        private ControllerRute controller;
        public InfoRute()
        {
            InitializeComponent();

            controller = new ControllerRute();

            InisialisasiListView();
            LoadDataRute();
        }

        private void InisialisasiListView()
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

            listOfRute = controller.ReadAll();

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

        private void OnCreateEventHandler(Rute rute)
        {
            listOfRute.Add(rute);

            ListViewItem item = new ListViewItem(rute.IdRute);
            item.SubItems.Add(rute.Kota_Asal);
            item.SubItems.Add(rute.Kota_Tujuan);
            item.SubItems.Add(rute.Waktu_Keberangkatan);
            item.SubItems.Add(rute.Waktu_Kedatangan);
            lvwRute.Items.Add(item);
        }

        private void OnUpdateEventHandler(Rute rute)
        {
            int index = lvwRute.SelectedIndices[0];
            ListViewItem itemRow = lvwRute.Items[index];
            itemRow.SubItems[0].Text = rute.IdRute;
            itemRow.SubItems[1].Text = rute.Kota_Asal;
            itemRow.SubItems[2].Text = rute.Kota_Tujuan;
            itemRow.SubItems[3].Text = rute.Waktu_Keberangkatan;
            itemRow.SubItems[4].Text = rute.Waktu_Kedatangan;
        }

        private void btnTambahRute_Click(object sender, EventArgs e)
        {
            EntryRute frmEntry = new EntryRute("Tambah Data Rute", controller);
            frmEntry.OnCreate += OnCreateEventHandler;
            frmEntry.ShowDialog();
        }

        private void btnUpdateRute_Click(object sender, EventArgs e)
        {
            if (lvwRute.SelectedItems.Count > 0)
            {
                Rute rute = listOfRute[lvwRute.SelectedIndices[0]];
                EntryRute frmEntry = new EntryRute("Edit Data Rute", rute, controller);
                frmEntry.OnUpdate += OnUpdateEventHandler;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapusBus_Click_1(object sender, EventArgs e)
        {
            if (lvwRute.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data rute ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Rute rute = listOfRute[lvwRute.SelectedIndices[0]];

                    var result = controller.Delete(rute);
                    if (result > 0) LoadDataRute();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKembali_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnCariRute_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCariRute.Text))
            {
                var result = controller.ReadByKota(txtCariRute.Text);
                lvwRute.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem listItem = new ListViewItem(item.IdRute);
                    listItem.SubItems.Add(item.Kota_Asal);
                    listItem.SubItems.Add(item.Kota_Tujuan);
                    listItem.SubItems.Add(item.Waktu_Keberangkatan);
                    listItem.SubItems.Add(item.Waktu_Kedatangan);
                    lvwRute.Items.Add(listItem);
                }
            }
            else
            {
                var result = controller.ReadAll();
                lvwRute.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem listItem = new ListViewItem(item.IdRute);
                    listItem.SubItems.Add(item.Kota_Asal);
                    listItem.SubItems.Add(item.Kota_Tujuan);
                    listItem.SubItems.Add(item.Waktu_Keberangkatan);
                    listItem.SubItems.Add(item.Waktu_Kedatangan);
                    lvwRute.Items.Add(listItem);
                }

            }
        }
    }
}
