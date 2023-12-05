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
    public partial class InfoPenumpang : Form
    {
        private List<Penumpang> listOfPenumpang = new List<Penumpang>();

        private ControllerPenumpang controller;
        public InfoPenumpang()
        {
            InitializeComponent();
            InisialisasiListView();

            controller = new ControllerPenumpang();

            LoadDataPenumpang();
        }

        private void InisialisasiListView()
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

            listOfPenumpang = controller.ReadAll();

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

        private void OnCreateEventHandler(Penumpang penumpang)
        {
            listOfPenumpang.Add(penumpang);
 
            var item = new ListViewItem(penumpang.IdPenumpang);
            item.SubItems.Add(penumpang.Nama);
            item.SubItems.Add(penumpang.NoKontak);
            item.SubItems.Add(penumpang.Gender);
            item.SubItems.Add(penumpang.NoKursi);

            lvwPenumpang.Items.Add(item);
        }

        private void OnUpdateEventHandler(Penumpang penumpang)
        {
            int index = lvwPenumpang.SelectedIndices[0];
            ListViewItem itemRow = lvwPenumpang.Items[index];
            itemRow.SubItems[0].Text = penumpang.IdPenumpang;
            itemRow.SubItems[1].Text = penumpang.Nama;
            itemRow.SubItems[2].Text = penumpang.NoKontak;
            itemRow.SubItems[3].Text = penumpang.Gender;
            itemRow.SubItems[4].Text = penumpang.NoKursi;
        }

        private void btnTambahPenumpang_Click(object sender, EventArgs e)
        {
            EntryPenumpang frmEntry = new EntryPenumpang("Tambah Data Penumpang", controller);
            frmEntry.OnCreate += OnCreateEventHandler;
            frmEntry.ShowDialog();
        }

        private void btnUpdatePenumpang_Click(object sender, EventArgs e)
        {
            if (lvwPenumpang.SelectedItems.Count > 0)
            {
                Penumpang penumpang = listOfPenumpang[lvwPenumpang.SelectedIndices[0]];
                EntryPenumpang frmEntry = new EntryPenumpang("Edit Data Penumpang", penumpang, controller);
                frmEntry.OnUpdate += OnUpdateEventHandler;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapusPenumpang_Click(object sender, EventArgs e)
        {
            if (lvwPenumpang.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data penumpang ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Penumpang penumpang = listOfPenumpang[lvwPenumpang.SelectedIndices[0]];

                    var result = controller.Delete(penumpang);
                    if (result > 0) LoadDataPenumpang();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnCariPenumpang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCariPenumpang.Text))
            {
                var result = controller.ReadByNama(txtCariPenumpang.Text);
                lvwPenumpang.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem listItem = new ListViewItem(item.IdPenumpang);
                    listItem.SubItems.Add(item.Nama);
                    listItem.SubItems.Add(item.NoKontak);
                    listItem.SubItems.Add(item.Gender);
                    listItem.SubItems.Add(item.NoKursi);
                    lvwPenumpang.Items.Add(listItem);
                }
            }
            else
            {
                var result = controller.ReadAll();
                lvwPenumpang.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem listItem = new ListViewItem(item.IdPenumpang);
                    listItem.SubItems.Add(item.Nama);
                    listItem.SubItems.Add(item.NoKontak);
                    listItem.SubItems.Add(item.Gender);
                    listItem.SubItems.Add(item.NoKursi);
                    lvwPenumpang.Items.Add(listItem);
                }

            }
        }
    }
}
