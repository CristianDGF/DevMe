/*
 * Program created on 04/23/2024 by:
 * Cristian David Gutiérrez Fernández
 * Francisco Javier Román Clemente
 * Mario Leví Pérez Díaz
 * Diana Laura Sandoval González
 * Arturo Uriel Sosa Ortiz
 * Anthony Alexander Zarate Bautista
 */

using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMe_v006
{
    class Ejecutar
    {
        public void EjecutarCodigoCSharp(string codigo, RichTextBox richTextBox)
        {


            // Ruta del directorio donde se encuentra el programa
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            // Ruta del archivo donde se escribirá el código
            string filePath = Path.Combine(directoryPath, "Codigo.cs");

            // Escribir el código en el archivo
            File.WriteAllText(filePath, codigo);

            // Compilar el archivo
            var provider = new CSharpCodeProvider();
            var parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Path.Combine(directoryPath, "Programa.exe");

            CompilerResults results = provider.CompileAssemblyFromFile(parameters, filePath);

            if (results.Errors.HasErrors)
            {
                string Errores = "";
                foreach (CompilerError error in results.Errors)
                {
                    Errores = Errores + error.ErrorText;
                    //MessageBox.Show(error.ErrorText, "Error de compilación");

                }

                MessageBox.Show(Errores);
                richTextBox.Text = Errores;
            }
            else
            {
                //MessageBox.Show("Programa compilado correctamente.", "Compilación exitosa");

                // Ejecutar el programa en una consola independiente
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {parameters.OutputAssembly}",
                    UseShellExecute = false,
                    CreateNoWindow = false
                });
            }
        }
    }
}
