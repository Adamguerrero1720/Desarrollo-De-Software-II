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
    public partial class FormClients : Form
    {
        Clients ClaseClientes = new Clients();
        private int indice = 0;

        public FormClients()
        {
            InitializeComponent();
        }

        private void bton_Cancelar_Click(object sender, EventArgs e)
        {
            txt_ID.Text = null;
            txt_Apellido.Text = null;
            txt_Nombre.Text = null;
            txt_Telefono.Text = null;
            combox_Genero.Text = null;  
            dt_combox.Text = null;
        }

        private void bton_Guardar_Click(object sender, EventArgs e)
        {
            ClaseClientes.Id = txt_ID.Text;
            ClaseClientes.Name = txt_Nombre.Text;
            ClaseClientes.LastName = txt_Apellido.Text;
            ClaseClientes.Phone = txt_Telefono.Text;
            ClaseClientes.Gender = combox_Genero.ValueMember;
            ClaseClientes.Date = dt_combox.Value;

            int indice = DGV.Rows.Add();

            DGV.Rows[indice].Cells[0].Value = txt_ID.Text;
            DGV.Rows[indice].Cells[1].Value = txt_Nombre.Text;
            DGV.Rows[indice].Cells[2].Value = txt_Apellido.Text;
            DGV.Rows[indice].Cells[3].Value = txt_Telefono.Text;
            DGV.Rows[indice].Cells[4].Value = combox_Genero.Text;
            DGV.Rows[indice].Cells[5].Value = dt_combox.Text;

            Limpiar();
        }

        private void Limpiar()
        {
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Telefono.Clear();
            combox_Genero.Text = null;
            dt_combox.Text = null;
        }

        private void bton_Borrar_Click(object sender, EventArgs e)
        {
            if(indice != -1)
            {
                DGV.Rows.RemoveAt(indice);
            }

        }
    }
}
