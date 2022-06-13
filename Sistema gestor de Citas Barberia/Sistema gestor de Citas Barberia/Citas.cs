using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Sistema_gestor_de_Citas_Barberia
{
    public partial class Citas : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=LAPTOP-ADAM\\SQLEXPRESS;Initial Catalog=Barberia;Integrated Security=True");

        public Citas()
        {
            InitializeComponent();
        }

        private void bton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bton_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bton_Minimizar_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bton_Close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void bton_Agregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Citas (Nombre_Cliente, Apellidos_Cliente, Telefono, Barbero, Fecha_Cita, Hora_Cita) VALUES (@nombrec,@apellidosc,@telefono,@barbero,@fechac,@horac)";
            cn.Open();
            SqlCommand comando = new SqlCommand(query,cn);
            comando.Parameters.AddWithValue("@nombrec", txt_Usuario.Text);
            comando.Parameters.AddWithValue("@apellidosc", txt_ApellidoC.Text);
            comando.Parameters.AddWithValue("@telefono", txt_Telefono.Text);
            comando.Parameters.AddWithValue("@barbero", Combox_Barbero.Text);
            comando.Parameters.AddWithValue("@fechac", DateTime_Citas.Text);
            comando.Parameters.AddWithValue("@horac", DateTime_HoraC.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Insertado");

            txt_Usuario.Clear();
            txt_ApellidoC.Clear();
            txt_Telefono.Clear();
            Combox_Barbero.Text = null;
            DateTime_Citas.Text = null;
            DateTime_HoraC.Text = null;

            cn.Close();
        }

        private void bton_visualizar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * From Citas", cn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void bton_Eliminar_Click(object sender, EventArgs e)
        {
            string query = "delete from Citas where Nombre_Cliente = @nombrec";
            cn.Open();
            SqlCommand comando = new SqlCommand(query, cn);
            comando.Parameters.AddWithValue("@nombrec", txt_Usuario.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            cn.Close();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barberia.Citas' table. You can move, or remove it, as needed.
            this.citasTableAdapter.Fill(this.barberia.Citas);
        }
    }
}
