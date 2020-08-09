//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        DateiEinlesen.cs
//Datum:        15.06.2020
//Beschreibung: Liest eine Textdatei in einen String
using System.IO;
using System.Text;

namespace Kryptographie
{
    partial class main
    {
        static void DateiEinlesen(ref string text, string dateiPfad)
        {
            FileStream FS = new FileStream(dateiPfad, FileMode.Open, FileAccess.Read);            
            StreamReader SR = new StreamReader(FS, Encoding.UTF8);

            text = SR.ReadToEnd();

            SR.Close();
            FS.Close();
        }
    }
}