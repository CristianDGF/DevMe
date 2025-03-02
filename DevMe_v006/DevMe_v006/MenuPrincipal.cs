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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMe_v006
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();  
            CentrarBotones();
            
            MostrarMenus(mp);
        }
        #region Variables
        int MenuAnterior;
        MenuPrincipalUC mp = new MenuPrincipalUC();
        #endregion

        #region Métodos propios

        private void CentrarBotones() {
            int y = (Size.Height- (404+35)) /2;
           
            BtnMenu.Location = new Point(BtnMenu.Location.X,y);
            BtnRetos.Location = new Point(BtnRetos.Location.X, y+82);
            BtnPerfil.Location = new Point(BtnPerfil.Location.X, y+82*2);
            BtnTienda.Location = new Point(BtnTienda.Location.X, y + 82*3);
            BtnAjustes.Location = new Point(BtnAjustes.Location.X, y + 82 * 4);
        }
        private async void CambiarImagen(string ImageClick, string direccion, PictureBox pictureBox)
        {
            Image img1 = Image.FromFile(ImageClick);
            pictureBox.Image = img1;
            
            await Task.Delay(150);
            Image img = Image.FromFile(direccion);
            pictureBox.Image = img;
            
        }
        private void MostrarMenus(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;
            PanDerecho.Controls.Clear();
            PanDerecho.Controls.Add(userControl);
            userControl.BringToFront();
        }
        #endregion

        #region Clicks de los botones del panel izquierdo  
        private async void BtnMenu_Click(object sender, EventArgs e)
        {
            
            CambiarImagen(@"Imagenes\Botones\BtnPanalClick.png", @"Imagenes\Botones\BtnPanal.png", BtnMenu);            
            
            if (MenuAnterior!=1) {
                await Task.Delay(150);
                mp.timer1.Enabled = true;
                mp.PizarronBug.Text = "";
                MostrarMenus(mp);
                MenuAnterior = 1; 
            }
            
        }

        private async void BtnRetos_Click(object sender, EventArgs e)
        {
            
            CambiarImagen(@"Imagenes\Botones\BtnRetosClick.png", @"Imagenes\Botones\BtnRetos.png", BtnRetos);
            if (MenuAnterior!=2) { 
                await Task.Delay(150);
                MenuRetos mr = new MenuRetos();
                MostrarMenus(mr);
                MenuAnterior = 2;
            }
        }

        private async void BtnPerfil_Click(object sender, EventArgs e)
        {
            CambiarImagen(@"Imagenes\Botones\BtnPerfilClick.png", @"Imagenes\Botones\BtnPerfil.png", BtnPerfil);
            
            if (MenuAnterior != 3)
            {
                await Task.Delay(150);
                MenuPerfil mp = new MenuPerfil();
                MostrarMenus(mp);
                MenuAnterior = 3;
            }
        }

        private async void BtnTienda_Click(object sender, EventArgs e)
        {
            CambiarImagen(@"Imagenes\Botones\BtnTiendaClick.png", @"Imagenes\Botones\BtnTienda.png", BtnTienda);
            if (MenuAnterior != 4)
            {
                await Task.Delay(150);
                MenuTienda mt = new MenuTienda();
                MostrarMenus(mt);
                MenuAnterior = 4;
            }
        }

        private async void BtnAjustes_Click(object sender, EventArgs e)
        {
            CambiarImagen(@"Imagenes\Botones\BtnAjustesClick.png", @"Imagenes\Botones\BtnAjustes.png", BtnAjustes);
            
            if (MenuAnterior != 5)
            {
                await Task.Delay(150);
                MenuAjustes ma = new MenuAjustes();
                MostrarMenus(ma);
                MenuAnterior = 5;
            }
        }

        #endregion

       
        private void MenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            CentrarBotones();
        }
    }
}
