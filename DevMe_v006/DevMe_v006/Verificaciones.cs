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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMe_v006
{
    class Verificaciones
    {
        public Verificaciones()
        {
        }
        public static bool Error = false;

        public bool IncioFin(RichTextBox richTextBox1, Label label1)
        {
            int posicionDelPuntero = richTextBox1.SelectionStart;


            bool fin = Regex.IsMatch(richTextBox1.Text, @"\bFin\b");

            bool inicio = Regex.IsMatch(richTextBox1.Text, @"\bInicio\b");

            string error1 = inicio ? "" : "No se encontro la palabra 'Inicio'.";
            string error2 = fin ? "" : "No se encontro la palabra 'Fin'.";


            Error = (inicio && fin) ? true : false;

            label1.Text = label1.Text + error1 + "\n" + error2;

            richTextBox1.Select(richTextBox1.TextLength, 0);
            richTextBox1.SelectionStart = posicionDelPuntero;
            return Error;
        }

        public static bool ComillasNoCerradas(string texto)
        {
            int countComillas = Regex.Matches(texto, @"[""']").Count;
            return countComillas % 2 != 0;
        }

        public string VerificarEscrituraDespuesDeFin(RichTextBox richTextBox1)
        {

            Match finMatch = Regex.Match(richTextBox1.Text, @"\bFin\b");
            string error1 = "";
            if (finMatch.Success)
            {

                int startIndex = finMatch.Index + finMatch.Length;


                if (startIndex < richTextBox1.Text.Length)
                {

                    string textoDespuesDeFin = richTextBox1.Text.Substring(startIndex);

                    error1 = (Regex.IsMatch(textoDespuesDeFin, @"^\s*$")) ? "" : "No se puede escribir despues de la palabra reservada 'Fin'.";

                }

            }

            return error1;
        }


        public bool EstaDentroDeComillas(RichTextBox richTextBox)
        {
            int cursorIndex = richTextBox.SelectionStart;
            string texto = richTextBox.Text;

            // Verificar si el índice del cursor está dentro de las comillas
            for (int i = cursorIndex - 1; i >= 0; i--)
            {
                if (texto[i] == '"')
                {
                    // Las comillas están abiertas
                    return false;
                }
                else if (texto[i] == '\n' || texto[i] == '\r')
                {
                    // Se alcanzó el final de la línea sin encontrar comillas
                    break;
                }
            }

            // Verificar si hay comillas de cierre después del cursor
            for (int i = cursorIndex; i < texto.Length; i++)
            {
                if (texto[i] == '"')
                {
                    // Las comillas están cerradas
                    return false;
                }
                else if (texto[i] == '\n' || texto[i] == '\r')
                {
                    // Se alcanzó el final de la línea sin encontrar comillas
                    break;
                }
            }

            // Si el cursor no está dentro de comillas
            return true;
        }


        public void VerificarComillas(RichTextBox codeRichTextBox, Label label2)
        {
            string texto = codeRichTextBox.Text;
            int numeroComillasAbiertas = texto.Count(c => c == '"');
            int indiceComillasAbiertas = texto.IndexOf('"');

            if (numeroComillasAbiertas % 2 != 0)
            {
                int numeroLinea = codeRichTextBox.GetLineFromCharIndex(indiceComillasAbiertas) + 1;
                label2.Text = ($"Error: Comillas abiertas en la línea {numeroLinea}");

            }
            else
            {
                //label2.Text=("Todas las comillas están cerradas.");
            }
        }
    }
}
