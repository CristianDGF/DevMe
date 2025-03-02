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
    [DefaultEvent("Click_mod")]
    public partial class BtnRectangular : UserControl
    {
        public BtnRectangular()
        {
            InitializeComponent();
        }
        
        public event EventHandler Click_mod;

        public string _LabelTxt;

        public string TextLabel {
            get { return _LabelTxt; }
            set { _LabelTxt = value; label1.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Evento click del btn
            cambiarImagen(@"Imagenes\Botones\BtnRectangularClick.png", @"Imagenes\Botones\BtnRectangular.png", pictureBox1);

            Click_mod?.Invoke(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1_Click(sender,e);

        }

        public async void cambiarImagen(string ImageClick, string direccion, PictureBox pictureBox)
        {
            label1.BackColor = Color.FromArgb(245, 175, 49);
            label1.Location = new Point(label1.Location.X,label1.Location.Y+5);
            Image img1 = Image.FromFile(ImageClick);
            pictureBox.Image = img1;

            await Task.Delay(200);
            label1.BackColor = Color.FromArgb(232, 155, 16);
            label1.Location = new Point(label1.Location.X, label1.Location.Y - 5);
            Image img = Image.FromFile(direccion);
            pictureBox.Image = img;
        }
    }
}
