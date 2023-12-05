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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            else
            {
                
            }
        }
        private void btnRute_Click(object sender, EventArgs e)
        {
            InfoRute infoRute = new InfoRute();
            infoRute.Show();
            this.Hide();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            InfoBus infoBus = new InfoBus();
            infoBus.Show();
            this.Hide();
        }

        private void btnPenumpang_Click(object sender, EventArgs e)
        {
            InfoPenumpang infoPenumpang = new InfoPenumpang();
            infoPenumpang.Show();
            this.Hide();
        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            InfoTiket infoTiket = new InfoTiket();
            infoTiket.Show();
            this.Hide();
        }
    }
}
