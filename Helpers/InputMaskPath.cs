using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryptographie
{
    partial class main
    {
        static bool InputMaskPath(bool sourceDest, bool encDec, ref string path)
        {
            string headline;
            string errorMessage = "Der Dateipfad \"" + path + "\" existiert nicht. Bite überprüfen Sie Ihre Eingabe!";
            if (sourceDest)
            {
                headline = "Bitte geben Sie den relativen Pfad zu der Datei an,\r\nwelche Sie " + (encDec ? "verschlüsseln" : "entschlüsseln") + " möchten.";
            }
            else
            {
                headline = "Bitte geben Sie den relativen Pfad zum Speicherort für die " + (encDec ? "entschlüsselte" : "verschlüsselte") + " Datei an.";
            }
            path = "";
            bool pathProcess = true;
            Console.CursorVisible = true;
            string errorShown = "";
            do
            {
                Console.Clear();
                Console.WriteLine(headline);
                Console.WriteLine();
                Console.WriteLine("Bestätigen Sie die Eingabe mit der Eingabetaste.");
                Console.WriteLine("Um zurück zu gelangen drücken Sie die Escape Taste.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sie befinden sich im Pfad:");
                WriteWithColor(ConsoleColor.Green, Directory.GetCurrentDirectory());
                Console.WriteLine();
                Console.WriteLine("Dateipfad: " + path);
                Console.WriteLine();
                Console.WriteLine();
                WriteWithColor(ConsoleColor.Red, errorShown);
                Console.CursorTop = 10;
                Console.CursorLeft = 11 + path.Length;

                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    pathProcess = false;
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    errorShown = "";
                    path = path.Substring(0, path.Length > 0 ? path.Length - 1 : 0);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (sourceDest)
                    {
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\" + path))
                        {
                            path = Directory.GetCurrentDirectory() + "\\" + path;
                            Console.CursorVisible = false;
                            return true;
                        }
                        else
                        {
                            errorShown = errorMessage;
                        }
                    }
                    else
                    {
                        if (!File.Exists(Directory.GetCurrentDirectory() + "\\" + path))
                        {
                            path = Directory.GetCurrentDirectory() + "\\" + path;
                            Console.CursorVisible = false;
                            return true;
                        }
                        else
                        {
                            errorShown = errorMessage;
                        }
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    errorShown = "";
                    path += key.KeyChar;
                }
                else
                {
                    //Nichts
                }
            } while (pathProcess);
            return false;
        }
    }
}
