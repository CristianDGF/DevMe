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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMe_v006
{
    class EditorArchivos
    {
        public static string NombreArchivo;

        #region Archivos del usuario
        public bool CrearArchivo()
        {
            bool TodoBien;
            SaveFileDialog CrearArchivo = new SaveFileDialog();
            CrearArchivo.Title = "Crear proyecto";
            CrearArchivo.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            CrearArchivo.FilterIndex = 1;
            CrearArchivo.RestoreDirectory = true;

            if (CrearArchivo.ShowDialog() == DialogResult.OK)
            {

                // Obtener la ruta del archivo seleccionado
                string nombreArchivo = CrearArchivo.FileName;
                NombreArchivo = nombreArchivo;
                try
                {
                    // Crear el archivo de texto en la ubicación seleccionada
                    using (StreamWriter escritor = new StreamWriter(nombreArchivo))
                    {
                        // No necesitamos escribir ningún contenido en este caso
                        // Simplemente crear el archivo vacío
                    }
                    DatosGlobales.RutaArchivo = nombreArchivo;


                    // Ruta del archivo

                    try
                    {
                        // Abre el archivo para escribir
                        using (StreamWriter writer = new StreamWriter(nombreArchivo))
                        {
                            // Escribe contenido en el archivo
                            writer.WriteLine("Inicio\n\n\n\nFin");
                        }

                        //MessageBox.Show("Se ha creado en el archivo correctamente.");
                        TodoBien = true;
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Ocurrió un error al crear en el archivo: " + ex.Message);
                        TodoBien = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el archivo: " + ex.Message);
                    TodoBien = false;
                }

            }
            else { TodoBien=false;}
            return TodoBien;
        }

        public void GuardarArchivo(string filePath, string Texto)
        {
            
            try
            {
                

                // Escribir contenido en el archivo
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(Texto);
                    
                }

                MessageBox.Show("El archivo se ha guardado correctamente.");
                
            }
            catch (Exception ex)
            {
                
                DialogResult resultado = MessageBox.Show("Ocurrió un error al guardar el archivo, no se encontro el archivo: " + filePath + ", desea guardarlo en otro lugar? ", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CrearArchivo();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    return;
                }
            }
            
        }

        public bool AbrirArchivo()
        {
            bool TodoBien;
            OpenFileDialog  AbrirArchivo = new OpenFileDialog();
            AbrirArchivo.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            AbrirArchivo.FilterIndex = 1;
            AbrirArchivo.RestoreDirectory = true;
            AbrirArchivo.FileName = "";

            if (AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta del archivo seleccionado
                    string filePath = AbrirArchivo.FileName;

                    DatosGlobales.RutaArchivo = filePath;
                    return TodoBien = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                    return TodoBien = false;
                }

            }
            else {
                return TodoBien = false;
            }
        }
        #endregion


        #region ArchivoRecientes

        private string rutaArchivo = "ArchivosRecientes.txt";

        public void AñadirRegistro(string registo) {
            // Ruta del archivo de texto
            

            // Contenido de la nueva línea que quieres agregar
            string nuevaLinea = registo;

            try
            {
                // Lee todo el contenido del archivo
                string contenidoActual = File.ReadAllText(rutaArchivo);

                // Verifica si la nueva línea ya existe en el contenido actual
                if (contenidoActual.Contains(nuevaLinea))
                {
                    // Elimina la nueva línea del contenido actual
                    contenidoActual = contenidoActual.Replace(nuevaLinea + Environment.NewLine, "");
                }

                // Concatena la nueva línea al contenido existente, separada por un salto de línea
                string nuevoContenido = nuevaLinea + Environment.NewLine + contenidoActual;

                // Escribe el nuevo contenido de vuelta al archivo
                File.WriteAllText(rutaArchivo, nuevoContenido);
                
                Console.WriteLine("Se ha añadido una nueva línea al inicio del archivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo: " + ex.Message);
            }
        }

        public void AcutalizarRegistro() {

            // Lista para almacenar las rutas que existen
            List<string> rutasExistentes = new List<string>();

            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Verifica cada ruta
                foreach (string ruta in lineas)
                {
                    // Verifica si el archivo existe
                    if (File.Exists(ruta))
                    {
                        // Si existe, agrega la ruta a la lista de rutas existentes
                        rutasExistentes.Add(ruta);
                    }
                    else
                    {
                        Console.WriteLine("El archivo no existe en la ruta: " + ruta);
                    }
                }

                // Escribe las rutas existentes de vuelta al archivo
                File.WriteAllLines(rutaArchivo, rutasExistentes);

                Console.WriteLine("Se han eliminado las rutas que no existen.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar el archivo: " + ex.Message);
            }

        }
    


        #endregion

    }
}
