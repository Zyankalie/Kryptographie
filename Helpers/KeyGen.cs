//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        KeyGen.cs
//Datum:        15.06.2020
//Beschreibung: Keyerstellungsmethode
using System;
using System.IO;
using System.Text;

namespace Kryptographie
{
    partial class main
    {
        static void KeyGen(ref string key, int length)
        {
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                key += (char)r.Next(0, 128);
            }
            DateiSchreiben(key, "key");
        }
    }
}