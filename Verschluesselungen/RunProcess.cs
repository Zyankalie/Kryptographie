//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        RunProgress.cs
//Datum:        15.06.2020
//Beschreibung: Ruft die unterschiedlichen Verschlüsselungsverfahren auf
using System.Globalization;

namespace Kryptographie
{
    partial class main
    {
        static void RunProcess(bool encDec, int encryptionMethod, string key, ref string textToWorkOn, ref string resultText)
        {
            switch (encryptionMethod)
            {
                case 0:
                    Caesar(encDec, key, ref textToWorkOn, ref resultText);
                    break;
                case 1:
                    Vigenere(encDec, key, ref textToWorkOn, ref resultText);
                    break;
                case 2:
                    Otp(encDec, key, ref textToWorkOn, ref resultText);
                    break;
                default:
                    //Nichts
                    break;
            }
        }
    }
}

