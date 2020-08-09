//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        CaesarEntschluesseln.cs
//Datum:        15.06.2020
//Beschreibung: Caesarentschlüsselung
namespace Kryptographie
{
    partial class main
    {
        static void CaesarEntschluesseln(string verschluesselt, ref string text, int key)
        {
            CaesarVerschluesseln(verschluesselt, ref text, 127 - key);
        }
    }
}