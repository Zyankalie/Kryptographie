//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        OtpVerschluesseln.cs
//Datum:        15.06.2020
//Beschreibung: Otpverschluesselung
namespace Kryptographie
{
    partial class main
    {
        static void OtpVerschluesseln(string text, ref string verschluesselt, string key)
        {
            for (int i = 0; i < text.Length; i++)
            {
                verschluesselt += (char)(text[i] ^ key[i]);
            }
        }
    }
}