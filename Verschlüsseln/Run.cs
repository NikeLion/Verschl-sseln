/* Author:      Nicolas Köppe
 * Datei:       Run.cs
 * Datum:       03.12.19 
 * Klasse:      IA119
 * Aenderung:   03.12 Entwicklungsbeginn 
*/

namespace Verschlüsseln
{
    partial class main
    {
        static void run()
        {
            // 1. Zentrale Daten definieren

            // 2. Splashinfo
            splashinfo();

            // 3. Lokale Daten
            bool running = true;

            // 4. Hauptschleife 
            while (running)
            {
                // 5. Menue
                menu(1);

                // 6. MenueAuswahl
                string input = menuSelection();

                // 7. Auswertung der Auswahl
                if (input == "1")
                {
                    // Verschlüseln
                    importFile();
                }
                else if (input == "2")
                {
                    // Aufgabe 2
                }
                else if (input == "x")
                {
                    running = false;
                }
                else
                {
                    // mögliche Fehlermeldung
                    System.Console.WriteLine("Falsche Eingabe.");
                }
            }
        }
    }
}