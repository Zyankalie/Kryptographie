//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        VigenereEntschluesseln.cs
//Datum:        15.06.2020
//Beschreibung: Vigenereentschluesselung
namespace Kryptographie
{
    partial class main
    {
        static void VigenereEntschluesseln(string verschluesselt, ref string text, string key)
        {
            int keyPosition = 0;
            for (int i = 0; i < verschluesselt.Length; i++)
            {
                text += (char)(verschluesselt[i] + (127 - key[keyPosition] % 127));
                keyPosition++;
                if (keyPosition > key.Length - 1)
                {
                    keyPosition = 0;
                }
            }
        }
    }
}