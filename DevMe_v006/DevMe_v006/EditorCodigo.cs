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
    public partial class EditorCodigo : Form
    {
        //Constructor
        public EditorCodigo()
        {
            InitializeComponent();
            pintar.sentencias(CodigoTxt, EtiquetaInvisible);
            CodigoTxt.Text = "Inicio\n\n\n\nFin"; ArchivoGuardo = true;

            CargarArchivo();
            
        }
        #region Variables
        public bool ArchivoGuardo;
        Pintar pintar = new Pintar();
        #endregion
        
        //Evento TextChange del CodigoTxt
        
        private void CodigoTxt_TextChanged(object sender, EventArgs e)
        {
            pintar.sentencias(CodigoTxt, EtiquetaInvisible);
            SePuedesDeshacer();
            ArchivoGuardo = false;
        }

        #region Deshacer y rehacer
        bool a = true;
        private Stack<string> redoStack = new Stack<string>();
        private Stack<string> undoStack = new Stack<string>();
        public void SePuedesDeshacer()
        {
            //label2.Text = a.ToString();
            EtiquetaInvisible.Text = CodigoTxt.Text;
            if (a == true)
            {
                // Almacenar el texto actual en la pila de deshacer
                undoStack.Push(EtiquetaInvisible.Text);
                redoStack.Clear(); // Limpiar la pila de rehacer
            }

        }

        private void Undo()
        {
            int posP = CodigoTxt.SelectionStart;

            if (undoStack.Count > 1)
            {
                redoStack.Push(undoStack.Pop()); // Mover el texto actual a la pila de rehacer
                EtiquetaInvisible.Text = undoStack.Peek(); // Restaurar el texto anterior
            }
            CodigoTxt.SelectionStart = posP;

        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(redoStack.Pop()); // Mover el texto a rehacer a la pila de deshacer
                EtiquetaInvisible.Text = undoStack.Peek(); // Restaurar el texto de rehacer
            }
        }

        #endregion

        #region Metodos
        private void InsertarCadena(string cadena)
        {
            //Insertar una cadena en el CodigoTxt
            int posicionCursor = CodigoTxt.SelectionStart;
            CodigoTxt.Text = CodigoTxt.Text.Insert(posicionCursor, cadena);
            CodigoTxt.SelectionStart = posicionCursor + cadena.Length;
        }

        public async void cambiarImagen(string ImageClick, string direccion, PictureBox pictureBox)
        {
            Image img1 = Image.FromFile(ImageClick);
            pictureBox.Image = img1;

            await Task.Delay(200);
            Image img = Image.FromFile(direccion);
            pictureBox.Image = img;
        }

        public void CargarArchivo() {
            if (DatosGlobales.RutaArchivo != null)
            {
                TextReader doc = new StreamReader(DatosGlobales.RutaArchivo);
                CodigoTxt.Text = doc.ReadToEnd();
                doc.Close();
                ArchivoGuardo = true;
            }
        }

        #endregion

        #region Clicks de los botones
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnPlayClick.png", @"Imagenes\Botones\BtnPlay.png", BtnPlay);

            Traducir t = new Traducir();
            string codigo = (t.Sentencias(CodigoTxt.Text));
            string codigoCSharp = codigo;

            richTextBox1.Text = (codigoCSharp);



            Ejecutar ejecutar = new Ejecutar();
            ejecutar.EjecutarCodigoCSharp(@"" + codigoCSharp, TxtChat);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnMenuClick.png", @"Imagenes\Botones\BtnMenu.png", BtnMenu);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnGuardarClick.png", @"Imagenes\Botones\BtnGuardar.png", BtnGuardar);
            EditorArchivos ed = new EditorArchivos();
            ed.GuardarArchivo(DatosGlobales.RutaArchivo,CodigoTxt.Text);
            ArchivoGuardo = true;
        }

        private void BtnNuevoArchivo_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnNuevoArchivoClick.png", @"Imagenes\Botones\BtnNuevoArchivo.png", BtnNuevoArchivo);
        }

        private void BtnAbrirArchivo_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnAbrirArchivoClick.png", @"Imagenes\Botones\BtnAbrirArchivo.png", BtnAbrirArchivo);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnCopiarClick.png", @"Imagenes\Botones\BtnCopiar.png", BtnCopiar);
            CodigoTxt.Copy();
        }

        private void BtnPegar_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnPegarClick.png", @"Imagenes\Botones\BtnPegar.png", BtnPegar);
            CodigoTxt.Paste(DataFormats.GetFormat("Text"));
        }

        private void BtnCortar_Click(object sender, EventArgs e)
        { 
            cambiarImagen(@"Imagenes\Botones\BtnCortarClick.png", @"Imagenes\Botones\BtnCortar.png", BtnCortar);
            CodigoTxt.Cut();
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnDeshacerClick.png", @"Imagenes\Botones\BtnDeshacer.png", BtnDeshacer);
            Undo();
            a = false;
            CodigoTxt.Text = EtiquetaInvisible.Text;
            a = true;
        }

        private void BtnRehacer_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnRehacerClick.png", @"Imagenes\Botones\BtnRehacer.png", BtnRehacer);
        }
        private void BtnArribaAbajo_Click(object sender, EventArgs e)
        {
            if (PanInferior.Size.Height == 220)
            {
                cambiarImagen(@"Imagenes\Botones\BtnAbajoClick.png", @"Imagenes\Botones\BtnArriba.png", BtnArribaAbajo);
                Ayuda.SetToolTip(BtnArribaAbajo, "Maximizar control.");
                PanInferior.Size = new Size(PanInferior.Width, 0);
            }
            else {
                cambiarImagen(@"Imagenes\Botones\BtnArribaClick.png", @"Imagenes\Botones\BtnAbajo.png", BtnArribaAbajo);
                Ayuda.SetToolTip(BtnArribaAbajo, "Minimizar control.");
                PanInferior.Size = new Size(PanInferior.Width, 220);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            cambiarImagen(@"Imagenes\Botones\BtnBuscarClick.png", @"Imagenes\Botones\BtnBuscar.png", BtnBuscar);
        }
       
        //Evento KeyDown del CodigoTxt
        private void CodigoTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z) // Verificar si se presionó Ctrl + Z (deshacer)
            {
                e.SuppressKeyPress = true; // Evitar que se procese la combinación de teclas
                Undo();
                a = false;
                CodigoTxt.Text = EtiquetaInvisible.Text;
                a = true;
            }

            if (e.Control && e.KeyCode==Keys.S) {
                EditorArchivos ed = new EditorArchivos();
                ed.GuardarArchivo(DatosGlobales.RutaArchivo,CodigoTxt.Text);
                ArchivoGuardo = true;
            }

        }
        //SubMenus izquierdos

        #region SubMenus izquierdos
        private void BtnSubMenu_Click(object sender, EventArgs e)
        {
            PanSubMenu2.Visible = false;
            PanSubMenu3.Visible = false;
            if (PanSubMenu1.Visible == true) { 

                PanSubMenu1.Visible = false;
                
            } else { 

                PanSubMenu1.Visible = true; 

            }
            
        }

        private void BtnSubMenu2_Click(object sender, EventArgs e)
        {
            PanSubMenu1.Visible = false;
            PanSubMenu3.Visible = false;
            if (PanSubMenu2.Visible == true)
            {

                PanSubMenu2.Visible = false;

            }
            else
            {

                PanSubMenu2.Visible = true;

            }
        }

        private void BtnSubMenu3_Click(object sender, EventArgs e)
        {
            PanSubMenu1.Visible = false;
            PanSubMenu2.Visible = false;
            if (PanSubMenu3.Visible == true)
            {

                PanSubMenu3.Visible = false;

            }
            else
            {

                PanSubMenu3.Visible = true;

            }
        }


        #endregion

        #endregion

        private void EditorCodigo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ArchivoGuardo==false) {
                
                DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios antes de cerrar?", "Guardar cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    EditorArchivos ed = new EditorArchivos();
                    ed.GuardarArchivo(DatosGlobales.RutaArchivo, CodigoTxt.Text);
                }
                else if (resultado == DialogResult.Cancel)
                {
                    e.Cancel = true; // Cancela el cierre del formulario
                } 
            }
            
        }
    }
}
