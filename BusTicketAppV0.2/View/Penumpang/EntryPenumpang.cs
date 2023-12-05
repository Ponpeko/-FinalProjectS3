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
    public partial class EntryPenumpang : Form
    {
        public delegate void CreateUpdateEventHandler(Penumpang penumpang);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private ControllerPenumpang controller;

        private bool isNewData = true;

        private Penumpang penumpang;
        public EntryPenumpang()
        {
            InitializeComponent();
        }

        public EntryPenumpang(string title, ControllerPenumpang controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public EntryPenumpang(string title, Penumpang obj, ControllerPenumpang controller)
         : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            penumpang = obj;

            txtNamaPenumpang.Text = penumpang.Nama;
            txtNoKontak.Text = penumpang.NoKontak;
            txtNoKursi.Text = penumpang.NoKursi;

            if(radioLaki.Checked == true)
            {
                penumpang.Gender = "L";
            } else
            {
                penumpang.Gender = "P";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNamaPenumpang.Clear();
            txtNoKontak.Clear();
            txtNoKursi.Clear();
            radioLaki.Checked = false;
            radioPr.Checked = false;
            txtNamaPenumpang.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) penumpang = new Penumpang();
            penumpang.Nama = txtNamaPenumpang.Text;
            penumpang.NoKontak = txtNoKontak.Text;
            penumpang.NoKursi = txtNoKursi.Text;
            if (radioLaki.Checked == true)
            {
                penumpang.Gender = "L";
            }
            else
            {
                penumpang.Gender = "P";
            }

            int result = 0;
            if (isNewData)
            {
                result = controller.Create(penumpang);
                if (result > 0)
                {
                    OnCreate(penumpang);

                    txtNamaPenumpang.Clear();
                    txtNoKontak.Clear();
                    txtNoKursi.Clear();
                    radioLaki.Checked = false;
                    radioPr.Checked = false;
                    txtNamaPenumpang.Focus();
                }
            }
            else
            {
                result = controller.Update(penumpang);
                if (result > 0)
                {
                    OnUpdate(penumpang);
                    this.Close();
                }
            }
        }
    }
}
