//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        VigenereVerschluesseln.cs
//Datum:        15.06.2020
//Beschreibung: Vigenereverschluesselung
namespace Kryptographie
{
    partial class main
    {
        static void VigenereVerschluesseln(string text, ref string verschluesselt, string key)
        {
            int keyPosition = 0;
            for (int i = 0; i < text.Length; i++)
            {
                verschluesselt += (char)((text[i] + key[keyPosition]) % 127);
                keyPosition++;
                if (keyPosition > key.Length - 1)
                {
                    keyPosition = 0;
                }
            }
        }
    }
}