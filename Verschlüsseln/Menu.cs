/* Author:      Nicolas Köppe
 * Datei:       Menue.cs
 * Datum:       03.12.19 
 * Klasse:      IA119
 * Aenderung:   03.12 Entwicklungsbeginn 
*/

using System;

namespace Verschlüsseln
{
    partial class main
    {
        static void menu(int menuNr)
        {
            if (menuNr == 1)
            {
                Console.WriteLine("(1) Verschlüsseln");
                Console.WriteLine("(2) Entschlüsseln");
                //Console.WriteLine("(3) Aufgabe 3");
                // Letzte Zeile
                Console.WriteLine("(x) Programm beenden");
            }
            else if (menuNr == 2)
            {   //Verschlüsseln
                Console.WriteLine("(1) Verschlüsseln");
                Console.WriteLine("(2) Entschlüsseln");
                //Console.WriteLine("(3) Aufgabe 3");
                // Letzte Zeile
                Console.WriteLine("(x) Programm beenden");
            }

        }
    }
}