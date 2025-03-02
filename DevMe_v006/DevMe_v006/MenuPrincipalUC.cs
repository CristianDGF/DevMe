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
    public partial class MenuPrincipalUC : UserControl
    {
        public MenuPrincipalUC()
        {
            InitializeComponent();
            EditorArchivos ed = new EditorArchivos();
            ed.AcutalizarRegistro();

        }

        #region Variables
        private EditorCodigo formSecundario;
        private string ruta = "ArchivosRecientes.txt";
        #endregion

        #region Métodos propios
        private async void BtnPresionado(string ImageClick, string direccion, PictureBox pictureBox, Label lbl)
        {
            Image img1 = Image.FromFile(ImageClick);
            pictureBox.Image = img1;
            lbl.BackColor = Color.FromArgb(251, 211, 179);

            await Task.Delay(200);
            Image img = Image.FromFile(direccion);
            pictureBox.Image = img;
            lbl.BackColor = Color.FromArgb(197, 154, 119);
        }
        private void AbrirEditorCodigo()
        {
            // Verificar si la instancia del formulario secundario no ha sido creada o si está cerrada
            if (formSecundario == null || formSecundario.IsDisposed)
            {

                // Si no ha sido creada o está cerrada, crear una nueva instancia
                formSecundario = new EditorCodigo();
                // Mostrar el formulario secundario
                formSecundario.Show();
                formSecundario.Focus();

                //label1.Text = DatosGlobales.EditorCodigoAbierto+"";
            }
            else
            {
                // Si ya está abierta, enfocarla en lugar de crear una nueva
                formSecundario.Focus();
                
            }
        }
        public void MostarArchivosRecientes()
        {
            PanRecientes.Controls.Clear();
            Label nuevaEtiqueta = new Label();

            // Establece las propiedades de la etiqueta
            nuevaEtiqueta.Text = "Archivos recientes:";
            Ayuda.SetToolTip(nuevaEtiqueta,"Estos son los archivos que haz creado recientemente.");
            nuevaEtiqueta.BackColor = Color.FromArgb(240, 218, 255);
            nuevaEtiqueta.TextAlign = ContentAlignment.MiddleCenter;
            nuevaEtiqueta.Location = new Point(12, 12);
            nuevaEtiqueta.Size = new Size(243, 47);
            nuevaEtiqueta.ForeColor = Color.FromArgb(71, 32, 124);
            nuevaEtiqueta.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);

            // Agrega la etiqueta al panel PanRecientes
            PanRecientes.Controls.Add(nuevaEtiqueta);
            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(ruta);
                int i = 0;
                // Itera sobre cada línea y crea un control RecienteTipoA por cada una
                for (int j = 0; j < lineas.Length; j++)
                {
                    if (File.Exists(lineas[j]))
                    {
                        i++;
                        // Crea un nuevo control RecienteTipoA
                        BtnReciente nuevoControl = new BtnReciente();
                        // Configura la propiedad que muestra la dirección de archivo
                        // Creas un nuevo control RecienteTipoA

                        nuevoControl.CambiarImagen(i);

                        FileInfo fileInfo = new FileInfo(lineas[j]);

                        string nombre = Path.GetFileNameWithoutExtension(fileInfo.Name);

                        // Verifica si la longitud del texto es mayor que 20
                        if (nombre.Length > 15)
                        {
                            nombre = nombre.Substring(0, 15) + "...";
                        }

                        // Obtener el nombre del archivo
                        nuevoControl.Ruta = lineas[j];
                        nuevoControl.Nombre = nombre;

                        Ayuda.SetToolTip(nuevoControl, "Abrir el archivo: "+nombre);

                        nuevoControl.Fecha = "Fecha de creación:\n" + fileInfo.CreationTime.ToString("dd/MM/yyyy");

                        // Agrega el control al formulario o a otro contenedor
                        PanRecientes.Controls.Add(nuevoControl); // Agrega al formulario actual
                                                                 // panel1.Controls.Add(nuevoControl); // Agrega a un panel llamado panel1
                                                                 // Ajusta la posición y el tamaño según sea necesario
                                                                 // Puedes definir la posición y el tamaño basándote en el índice del control
                        nuevoControl.Location = new System.Drawing.Point(10, -120 + (nuevoControl.Height + 10) * PanRecientes.Controls.Count);
                        nuevoControl.PictureBoxClick += NuevoControl_Click;
                        if (i == 3) { i = 0; }

                    }
                    else {  }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo:sdsbjdbs " + ex.Message);
            }
        }
        private void NuevoControl_Click(object sender, EventArgs e)
        {
            // Aquí puedes manejar el evento de clic en el PictureBox
            BtnReciente controlClickeado = (BtnReciente)sender;
            DialogResult resultado = MessageBox.Show("¿Desea abrir el proyecto " + controlClickeado.Nombre + "?", "Abrir archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                DatosGlobales.RutaArchivo = controlClickeado.Ruta;
                AbrirEditorCodigo();
            }
            else if (resultado == DialogResult.No) { }



        }
                
        #endregion

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            
            BtnPresionado(@"Imagenes\Botones\BtnCrearClick.png", @"Imagenes\Botones\BtnCrear.png", BtnCrear, LblCrearArchivo);
            await Task.Delay(200);
            {
                EditorArchivos ed = new EditorArchivos();
                if (ed.CrearArchivo() == true) { ed.AñadirRegistro(EditorArchivos.NombreArchivo); MostarArchivosRecientes(); AbrirEditorCodigo(); 
                    
                }
            }
            
        }

        private async void BtnAbrir_Click(object sender, EventArgs e)
        {
            BtnPresionado(@"Imagenes\Botones\BtnAbrirClick.png", @"Imagenes\Botones\BtnAbrir.png", BtnAbrir, LblAbrir);
            await Task.Delay(200);
            EditorArchivos ed = new EditorArchivos();

            if (ed.AbrirArchivo() == true) { AbrirEditorCodigo(); }
        }

        private void MenuPrincipalUC_Load(object sender, EventArgs e)
        {
            MostarArchivosRecientes();
            timer1.Enabled = true;
            PizarronBug.Text = "";
        }

        private void PanMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            
            if (Size.Width < 830 || Size.Height < 530) { PizarronBug.Visible = false; } else { PizarronBug.Visible = true; }
        }
        public int i = 0;
        public string texto = "Mi nombre es Bug, soy la mascota del programa DevMe, este programa ayudará a mejorar tu lógica de programación la la utilización de diferentes herramientas.";
        private void timer1_Tick(object sender, EventArgs e)
        {
            PizarronBug.Text = PizarronBug.Text+texto[i]+"";
            i++;            
            if (i>=texto.Length) { timer1.Enabled = false; i = 0; }
        }
        int j = 0;
        private void Bug_Click(object sender, EventArgs e)
        {
            timer2.Interval = 100;
            

            timer2.Enabled = (timer2.Enabled==true)?false:true;


            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;
            if (j == 1) { Image img = Image.FromFile(@"Imagenes\Bug\BugAbrazo.png"); Bug.Image = img; }
            if (j == 2) { Image img = Image.FromFile(@"Imagenes\Bug\BugMaestro.png"); Bug.Image = img; }
            if (j == 3) { Image img = Image.FromFile(@"Imagenes\Bug\BugPregunta.png"); Bug.Image = img; }
            if (j == 4) { Image img = Image.FromFile(@"Imagenes\Bug\BugEnojado.png"); Bug.Image = img; }
            if (j == 4) { j = 0; }
        }
    }
}
