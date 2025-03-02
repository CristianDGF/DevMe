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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMe_v006
{
    class Pintar
    {
        public Pintar() { }

        public void sentencias(RichTextBox codeRichTextBox, Label label1)
        {
            string keywords = @"\b(Imprimir|LimpiarConsola|CrearEntero|CrearCadena|CrearFlotante|CrearBooleano|CrearBooleano|GuardarEntero|GuardarCadena|GuardarFlotante|Si|SiNo|Entonces|Mientras|Hacer)\b";
            MatchCollection keywordMatches = Regex.Matches(codeRichTextBox.Text, keywords);

            string startEnd = @"\b(?:Inicio|Fin)\b";
            MatchCollection startEndMatches = Regex.Matches(codeRichTextBox.Text, startEnd);


            string types = @"\b(InicializarEntero|InicializarCadena|InicializarFlotante)\b";
            MatchCollection typeMatches = Regex.Matches(codeRichTextBox.Text, types);

            string coments = "//(.+)";
            MatchCollection comentsMatches = Regex.Matches(codeRichTextBox.Text, coments);

            string strings = "\"([^\"]*)\"";
            MatchCollection stringCollection = Regex.Matches(codeRichTextBox.Text, strings);

            string variableType = @"\b(Entero|Cadena|Flotante|Booleano)\b";
            MatchCollection variableCollection = Regex.Matches(codeRichTextBox.Text, variableType);

            string variableName = @"(?:CrearEntero|CrearCadena|CrearFlotante|CrearBooleano)\s+(\w+)";
            MatchCollection nameCollection = Regex.Matches(codeRichTextBox.Text, variableName);



            string signos = "[<>!=]";
            MatchCollection signosMatches = Regex.Matches(codeRichTextBox.Text, signos);

            string numbers = @"-?\d{1,3}(,\d{3})*(\.\d+)?";
            MatchCollection numbersMatches = Regex.Matches(codeRichTextBox.Text, numbers);


            int orginalIndex = codeRichTextBox.SelectionStart;
            int originalLength = codeRichTextBox.SelectionLength;
            Color originalColor = Color.Black;

            label1.Focus();

            codeRichTextBox.SelectionStart = 0;
            codeRichTextBox.SelectionLength = codeRichTextBox.Text.Length;
            codeRichTextBox.SelectionColor = originalColor;

            Seleccion(keywordMatches, codeRichTextBox, Color.FromArgb(0, 0, 99, 177));
            Seleccion(startEndMatches, codeRichTextBox, Color.DarkBlue);
            Seleccion(typeMatches, codeRichTextBox, Color.DarkCyan);
            Seleccion(comentsMatches, codeRichTextBox, Color.Orange);
            Seleccion(stringCollection, codeRichTextBox, Color.Green);
            //Seleccion(variableCollection, codeRichTextBox, Color.Red);
            //Seleccion(nameCollection, codeRichTextBox, Color.Purple);
            Seleccion(signosMatches, codeRichTextBox, Color.Cyan);
            Seleccion(numbersMatches, codeRichTextBox, Color.Coral);

            codeRichTextBox.SelectionStart = orginalIndex;
            codeRichTextBox.SelectionLength = originalLength;
            codeRichTextBox.SelectionColor = originalColor;
            codeRichTextBox.Focus();

        }

        private void Seleccion(MatchCollection Coleccion, RichTextBox codeRichTextBox, Color color)
        {
            foreach (Match m in Coleccion)
            {
                codeRichTextBox.SelectionStart = m.Index;
                codeRichTextBox.SelectionLength = m.Length;
                codeRichTextBox.SelectionColor = color;

            }

        }
    }
}
