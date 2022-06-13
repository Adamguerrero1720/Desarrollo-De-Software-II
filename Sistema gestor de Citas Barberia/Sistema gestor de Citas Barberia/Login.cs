using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Sistema_gestor_de_Citas_Barberia
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-ADAM\\SQLEXPRESS;Initial Catalog=Barberia;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void lbl_Hora_Click(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString();
        }

        private void bton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bton_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bton_Ingresar_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cm = new SqlCommand("select Usuario,Contraseña from Logueo where Usuario='" + txt_Usuario.Text + "' and Contraseña='" + txt_Contraseña.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bienvenido");
                Citas form = new Citas();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario y/o contraseña son incorrectos");
                txt_Usuario.Text = null;
                txt_Contraseña.Text = null;
            }
            cn.Close();
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void Validar()
        {
            if (txt_Usuario.Text == string.Empty || txt_Contraseña.Text == string.Empty)
            {
                bton_Ingresar.Enabled = false;
            }
            else
            {
                bton_Ingresar.Enabled = true;
            }
        }
    }
}
