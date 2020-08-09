//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        InputMaskKey.cs
//Datum:        15.06.2020
//Beschreibung: Eingabemaske für einen Key
using System;

namespace Kryptographie
{
    partial class main
    {
        static bool InputMaskKey(int encryptionMethod, ref string encryptionKey)
        {
            bool userInputActive = true;
            encryptionKey = "";
            do
            {
                Console.Clear();
                Console.WriteLine($"Bitte geben Sie einen Schlüssel für die {GetMethodByInt(encryptionMethod)}-Verschlüsselung an.");
                Console.WriteLine(encryptionKey);
                Console.CursorTop = 2;
                Console.CursorLeft = encryptionKey.Length;
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace)
                {
                    encryptionKey = encryptionKey.Substring(0, encryptionKey.Length > 0 ? encryptionKey.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    userInputActive = false;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    return true;
                }
                else
                {
                    if (encryptionMethod == 0)
                    {
                        if (char.IsDigit(key.KeyChar)
                            && ((key.KeyChar == '0'
                            && encryptionKey.Length > 0) || (key.KeyChar != '0'))
                            || key.KeyChar == '-' && encryptionKey.Length == 0)
                        {
                            encryptionKey += key.KeyChar;
                        }
                        else
                        {
                            //Nichts
                        }
                    }
                    else if (encryptionMethod == 1)
                    {
                        encryptionKey += key.KeyChar;
                    }
                    else if (encryptionMethod == 2)
                    {
                        //OTP-Regeln
                    }
                    else
                    {
                        //Nichts
                    }
                }
            } while (userInputActive);
            return false;
        }
    }
}
