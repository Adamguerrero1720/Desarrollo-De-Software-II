using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Pacientes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bton_Acceder_Click(object sender, EventArgs e)
        {
           if (txt_User.Text == "admin" && txt_Password.Text == "admin")
            {
                var main = new FormClients();
                main.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("User and Password are admin");
            }
        }

        private void bton_Cancelar_Click(object sender, EventArgs e)
        {
            txt_User.Clear();
            txt_Password.Clear();
        }
    }
}
