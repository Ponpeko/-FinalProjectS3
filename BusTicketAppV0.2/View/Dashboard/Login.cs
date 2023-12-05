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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Username atau password salah");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
