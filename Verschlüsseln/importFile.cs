/* Author:      Nicolas Köppe
 * Datei:       Aufgabe1.cs
 * Datum:       03.12.19 
 * Klasse:      IA119
 * Aenderung:   03.12 Entwicklungsbeginn 
*/

using System;
using System.IO;

namespace Verschlüsseln
{
    partial class main
    {

        static void importFile()
        {
            Console.WriteLine("Wählen Sie die zu verschlüsselnde Datei aus: ");
            string path = Directory.GetCurrentDirectory() + "\\data";
            //Console.WriteLine(path);
            string[] files = Directory.GetFiles(path);
            //String path = "data\\";
            //string[] files = { path + "it.txt", path +"source.csv" };
            String[] filesName = new string[files.Length];
            files.CopyTo(filesName,0);
            for (int index = 0; index < filesName.Length; index++)
            {
            //Console.WriteLine("before replace: "  + files[index]);
                 filesName[index] = filesName[index].Replace(path+"\\", "");
                 files[index] = files[index].Replace("txt", "asd");
            //Console.WriteLine("after replace: " + files[index]);
            }

            int selectedClass = -1;
            Console.WriteLine(File.Exists(files[selectedClass]));
            {
                selectedClass = multipleChoice(true, filesName);
            } while (!File.Exists(files[selectedClass]))

                using (StreamReader sr = new StreamReader(files[selectedClass]))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }

    }
}