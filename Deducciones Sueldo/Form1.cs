using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deducciones_Sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_Hora.Text = dt.ToString("F");
        }

        private void txt_SueldoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bton_Calcular_Click(object sender, EventArgs e)
        {
            double AFP = 0.0287D;
            double SFS = 0.0304D;
            double TotalD = AFP - SFS;
            double SueldoB = double.Parse(txt_SueldoB.Text);

            if (SueldoB < 34609)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }

            if (SueldoB > 34685 && SueldoB <= 52027)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }

            if (SueldoB > 52027 && SueldoB <= 72260)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }

            if (SueldoB > 72260)
            {
                txt_AFP.Text = Convert.ToString(Afp(SueldoB));
                txt_SFS.Text = Convert.ToString(Sfs(SueldoB));
                Totaldescuentos(SueldoB, TotalD);
                txt_ISR.Text = Convert.ToString(Isr(SueldoB, TotalD));
                txt_SueldoN.Text = Convert.ToString(SueldoNe(SueldoB, TotalD));
            }
        }

        // Metodos para llamar
        #region Metodos para llamar

        public static double Afp(double SueldoB)
        {
            double a = Math.Round(SueldoB * 0.0287, 3);
            return a;
        }

        public static double Sfs(double SueldoB)
        {
            double a = Math.Round(SueldoB * 0.0304, 3);
            return a;
        }

        public static double Totaldescuentos(double SueldoB, double TotalD)
        {
            double a = Math.Round(Afp(SueldoB) + Sfs(SueldoB) + Isr(SueldoB, TotalD), 2);
            return a;
        }

        public static double SueldoNe(double SueldoBruto, double TotalD)
        {
            double a = Math.Round(SueldoBruto - Totaldescuentos(SueldoBruto, TotalD), 2);
            return a;
        }

        public static double Isr(double SueldoB, double TotalD)
        {
            while (true)
            {
                if (SueldoB < 34609)
                {
                    double a = 0;
                    return a;
                }
                if (SueldoB > 34685 && SueldoB <= 52027)
                {

                    double b = Math.Round(((((SueldoB - TotalD) * 12) - 416220.01) * 0.15) / 12, 2);
                    return b;
                }

                if (SueldoB > 52027 && TotalD <= 72260)
                {
                    double c = Math.Round(((((SueldoB - TotalD) * 12) - 624329.01) * 0.20) / 12, 2);
                    return c;
                }

                if (SueldoB > 72260)
                {
                    double d = Math.Round(((((SueldoB - TotalD) * 12) - 867123.01) * 0.25) / 12, 2);
                    return d;
                }
            }
        }
        #endregion
    }
}
