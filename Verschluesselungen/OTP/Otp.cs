//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Otp.cs
//Datum:        15.06.2020
//Beschreibung: Otpverfahren
using System;

namespace Kryptographie
{
    partial class main
    {
        static void Otp(bool encDec, string key, ref string textToWorkOn, ref string resultText)
        {
            if (encDec)
            {
                OtpVerschluesseln(textToWorkOn, ref resultText, key);
            }
            else
            {
                OtpEntschluesseln(textToWorkOn, ref resultText, key);
            }
        }
    }
}