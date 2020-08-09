//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        CaesarVerschluesseln.cs
//Datum:        15.06.2020
//Beschreibung: Caesarverschlüsselung
using System.IO;
using System.Text;

namespace Kryptographie
{
    partial class main
    {
        static void CaesarVerschluesseln(string text, ref string verschluesselt, int key)
        {
            for (int i = 0; i < text.Length; i++)
                verschluesselt += (char)((text[i] + key) % 127);
        }
    }
}