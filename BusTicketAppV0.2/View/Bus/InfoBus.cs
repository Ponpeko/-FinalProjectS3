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
    public partial class InfoBus : Form
    {
        private List<Bus> listOfBus = new List<Bus>();
        private ControllerBus controller;

        public InfoBus()
        {
            InitializeComponent();
            InisialisasiListView();

            controller = new ControllerBus();

            LoadDataBus();
        }

        private void InisialisasiListView()
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

            listOfBus = controller.ReadAll();

            foreach (var bus in listOfBus)
            {
                
                var item = new ListViewItem(bus.IdBus);
                item.SubItems.Add(bus.NamaBus);
                item.SubItems.Add(bus.JenisBus);
                item.SubItems.Add(bus.Kapasitas);

                lvwBus.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Bus bus)
        {
            listOfBus.Add(bus);

            ListViewItem item = new ListViewItem(bus.IdBus);
            item.SubItems.Add(bus.NamaBus);
            item.SubItems.Add(bus.JenisBus);
            item.SubItems.Add(bus.Kapasitas);
            lvwBus.Items.Add(item);
        }

        private void OnUpdateEventHandler(Bus bus)
        {
            int index = lvwBus.SelectedIndices[0];
            ListViewItem itemRow = lvwBus.Items[index];
            itemRow.SubItems[0].Text = bus.IdBus;
            itemRow.SubItems[1].Text = bus.NamaBus;
            itemRow.SubItems[2].Text = bus.JenisBus;
            itemRow.SubItems[3].Text = bus.Kapasitas;
        }

        private void btnTambahBus_Click(object sender, EventArgs e)
        {
            EntryBus frmEntry = new EntryBus("Tambah Data Bus", controller);
            frmEntry.OnCreate += OnCreateEventHandler;
            frmEntry.ShowDialog();
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            if (lvwBus.SelectedItems.Count > 0)
            {
                Bus bus = listOfBus[lvwBus.SelectedIndices[0]];
                EntryBus frmEntry = new EntryBus("Edit Data Bus", bus, controller);
                frmEntry.OnUpdate += OnUpdateEventHandler;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnHapusBus_Click(object sender, EventArgs e)
        {
            if (lvwBus.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data bus ingin dihapus ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Bus bus = listOfBus[lvwBus.SelectedIndices[0]];

                    var result = controller.Delete(bus);
                    if (result > 0) LoadDataBus();
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

        private void btnCariBus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCariBus.Text))
            {
                var result = controller.ReadByBus(txtCariBus.Text);
                lvwBus.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem listItem = new ListViewItem(item.IdBus);
                    listItem.SubItems.Add(item.NamaBus);
                    listItem.SubItems.Add(item.JenisBus);
                    listItem.SubItems.Add(item.Kapasitas);
                    lvwBus.Items.Add(listItem);
                }
            }
            else
            {
                var result = controller.ReadAll();
                lvwBus.Items.Clear();
                foreach (var item in result)
                {
                    ListViewItem listItem = new ListViewItem(item.IdBus);
                    listItem.SubItems.Add(item.NamaBus);
                    listItem.SubItems.Add(item.JenisBus);
                    listItem.SubItems.Add(item.Kapasitas);
                    lvwBus.Items.Add(listItem);
                }

            }
        }

        private void InfoBus_Load(object sender, EventArgs e)
        {

        }
    }
}
