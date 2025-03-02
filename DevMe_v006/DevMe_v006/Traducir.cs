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

namespace DevMe_v006
{
    class Traducir
    {
        public Traducir() { }

        public string Sentencias(String codigoCSharp)
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            string iniciofin = "Console.ForegroundColor = ConsoleColor.Blue;";
            string colorEntrada = "Console.ForegroundColor = ConsoleColor.White;";
            string colorSalida = "Console.ForegroundColor = ConsoleColor.Green;";
            codigoCSharp = codigoCSharp.Replace("Inicio", "using System;\n class Programa{\n  static void Main(){ " + iniciofin + "Console.WriteLine(\"**Inicio del programa.**\");").Replace("Fin", iniciofin + "Console.WriteLine(\"**Fin del Programa.**\");Console.ReadKey();\n}\n}");

            //Creación de variables sintaxis: TipoVariable NombreVariable            
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bCrearEntero\s+(\w+)\b", "int $1;");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bCrearCadena\s+(\w+)\b", "string $1;");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bCrearFlotante\s+(\w+)\b", "float $1;");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bCrearBooleano\s+(\w+)\b", "bool $1;");



            //Guardar el valor ingresado por consola en las vaiables
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bGuardarEntero\s+(\w+)\b", colorEntrada + "\n$1 = int.Parse(Console.ReadLine());");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bGuardarCadena\s+(\w+)\b", colorEntrada + "\n$1 = Console.ReadLine();");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bGuardarFlotante\s+(\w+)\b", colorEntrada + "\n$1 = float.Parse(Console.ReadLine());");

            //Crear y guardar valores en variables
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bInicializarEntero\s+(\w+)\b", colorEntrada + "\nint $1 = int.Parse(Console.ReadLine());");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bInicializarCadena\s+(\w+)\b", colorEntrada + "\nstring $1 = Console.ReadLine();");
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bInicializarFlotante\s+(\w+)\b", colorEntrada + "\nfloat $1 = float.Parse(Console.ReadLine());");


            //Limpiar consola
            codigoCSharp = Regex.Replace(codigoCSharp, @"\bLimpiarConsola\b", "Console.Clear();");

            //Mostrar el texto por consola 
            codigoCSharp = Regex.Replace(codigoCSharp, @"Imprimir\s*\((.*?)\)", colorSalida + "Console.WriteLine($1)" + ";");

            //Cambiar Si por if
            codigoCSharp = Regex.Replace(codigoCSharp, @"Si(.*?)Entonces(.*?){", "if ($1){");
            codigoCSharp = Regex.Replace(codigoCSharp, @"SiNo\b", "else");
            return codigoCSharp;
        }
    }
}
