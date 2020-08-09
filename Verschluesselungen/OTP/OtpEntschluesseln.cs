//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        OtpEntschluesseln.cs
//Datum:        15.06.2020
//Beschreibung: otpentschluesselung
namespace Kryptographie
{
    partial class main
    {
        static void OtpEntschluesseln(string verschluesselt, ref string text, string key)
        {
            for (int i = 0; i < verschluesselt.Length; i++)
            {
                text += (char)(verschluesselt[i] ^ key[i]);
            }
        }
    }
}