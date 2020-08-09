//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        DateiSchreiben.cs
//Datum:        15.06.2020
//Beschreibung: Schreibt einen String in eine Textdatei
using System.IO;
using System.Text;

namespace Kryptographie
{
    partial class main
    {
        static void DateiSchreiben(string resultText, string destPath)
        {
            FileStream FS = new FileStream(destPath + ".txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);
            SW.WriteLine(resultText);
            SW.Close();
            FS.Close();
        }
    }
}