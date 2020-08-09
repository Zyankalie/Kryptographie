//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Vigenere.cs
//Datum:        15.06.2020
//Beschreibung: Vigenereverfahren
using System;

namespace Kryptographie
{
    partial class main
    {
        static void Vigenere(bool encDec, string key, ref string textToWorkOn, ref string resultText)
        {
            if (encDec)
            {
                VigenereVerschluesseln(textToWorkOn, ref resultText, key);
            }
            else
            {
                VigenereEntschluesseln(textToWorkOn, ref resultText, key);
            }
        }
    }
}