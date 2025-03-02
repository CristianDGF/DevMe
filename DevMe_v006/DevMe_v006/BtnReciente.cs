/*
 * Program created on 04/23/2024 by:
 * Cristian David Gutiérrez Fernández
 * Francisco Javier Román Clemente
 * Mario Leví Pérez Díaz
 * Diana Laura Sandoval González
 * Arturo Uriel Sosa Ortiz
 * Anthony Alexander Zarate Bautista
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMe_v006
{
    public partial class BtnReciente : UserControl
    {
        public BtnReciente()
        {
            InitializeComponent();
        }
        public event EventHandler PictureBoxClick;

        public string _Nombre;
        public string _Fecha;
        public string _Ruta;


        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; label1.Text = value; Ayuda.SetToolTip(pictureBox1,"Abrir el proyecto "+value); Ayuda.SetToolTip(label2, "Abrir el proyecto " + value); Ayuda.SetToolTip(label1, "Abrir el proyecto " + value); }
        }
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; label2.Text = value; }
        }
        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBoxClick?.Invoke(this, EventArgs.Empty);
        }

        public void CambiarImagen(int i)
        {
            if (i == 1)
            {
                pictureBox1.Image = Properties.Resources.RecientesBG1;
                label1.BackColor = Color.FromArgb(252, 239, 98);
                label2.BackColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(155, 226, 254);
            }
            else if (i == 2)
            {
                pictureBox1.Image = Properties.Resources.RecientesBG2;
                label1.BackColor = Color.FromArgb(253, 245, 159);
                label2.BackColor = Color.FromArgb(142, 77, 1);
                label1.ForeColor = Color.FromArgb(142, 77, 1);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.RecientesBG3;
                label1.BackColor = Color.FromArgb(205, 113, 248);
                label2.BackColor = Color.FromArgb(15, 177, 216);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }

        private void Ayuda_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
