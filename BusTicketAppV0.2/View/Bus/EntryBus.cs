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
    public partial class EntryBus : Form
    {
        public delegate void CreateUpdateEventHandler(Bus bus);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private ControllerBus controller;

        private bool isNewData = true;

        private Bus bus;
        public EntryBus()
        {
            InitializeComponent();
        }

        public EntryBus(string title, ControllerBus controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public EntryBus(string title, Bus obj, ControllerBus controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            bus = obj; 
                      
            txtNamaBus.Text = bus.NamaBus;
            txtJenisBus.Text = bus.JenisBus;
            cmbKapasitas.Text = bus.Kapasitas;
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (isNewData) bus = new Bus();
            bus.NamaBus = txtNamaBus.Text;
            bus.JenisBus = txtJenisBus.Text;
            bus.Kapasitas = cmbKapasitas.Text;
            int result = 0;
            if (isNewData)
            {
                result = controller.Create(bus);
                if (result > 0)
                {
                    OnCreate(bus);

                    txtNamaBus.Clear();
                    txtJenisBus.Clear();
                    cmbKapasitas.Text = "";
                    txtNamaBus.Focus();
                }
            }
            else
            {
                result = controller.Update(bus);
                if (result > 0)
                {
                    OnUpdate(bus);
                    this.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNamaBus.Clear();
            txtJenisBus.Clear();
            cmbKapasitas.Text = "";
            txtNamaBus.Focus();
        }
    }
}
