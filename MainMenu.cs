namespace Kryptographie
{
    partial class main
    {
        static void MainMenu()
        {
            string[] encryptionMethods = { "Caesar", "Vigenere", "OTP", "Programm schließen." };
            string[] encryptionDecryption = { "Verschlüsseln", "Entschlüsseln", "Zurück" };

            int selectedEncryptionMethod;
            int selectedMode;

            bool menuActive = true;
            bool encDecActive;
            bool sourcePathSelection;
            bool destPathSelection;

            string sourcePath = "";
            string destPath = "";
            string key = "";

            string textToWorkOn = "";
            string resultText = "";

            do
            {
                selectedEncryptionMethod = ShowMenu(ref encryptionMethods, "Bitte wählen Sie ein Verfahren aus.");
                if (selectedEncryptionMethod == 0)
                {
                    encDecActive = true;
                    do
                    {
                        selectedMode = ShowMenu(ref encryptionDecryption, "Wollen sie ver- oder entschlüsseln?");
                        if (selectedMode == 0)
                        {
                            sourcePathSelection = true;
                            do
                            {
                                if (InputMaskPath(true, true, ref sourcePath))
                                {
                                    DateiEinlesen(ref textToWorkOn, sourcePath);
                                    destPathSelection = true;
                                    do
                                    {
                                        if (InputMaskPath(false, true, ref destPath))
                                        {
                                            if (InputMaskKey(selectedEncryptionMethod, ref key))
                                            {
                                                RunProcess(true, selectedEncryptionMethod, key, ref textToWorkOn, ref resultText);
                                                DateiSchreiben(resultText, destPath);
                                                destPathSelection = false;
                                                sourcePathSelection = false;
                                                encDecActive = false;
                                            }
                                            else
                                            {
                                                //Nichts
                                            }
                                        }
                                        else
                                        {
                                            destPathSelection = false;
                                        }
                                    } while (destPathSelection);
                                }
                                else
                                {
                                    sourcePathSelection = false;
                                }
                            } while (sourcePathSelection);
                        }
                        else if (selectedMode == 1)
                        {
                            sourcePathSelection = true;
                            do
                            {
                                if (InputMaskPath(true, false, ref sourcePath))
                                {
                                    DateiEinlesen(ref textToWorkOn, sourcePath);
                                    destPathSelection = true;
                                    do
                                    {
                                        if (InputMaskPath(false, false, ref destPath))
                                        {
                                            if (InputMaskKey(selectedEncryptionMethod, ref key))
                                            {
                                                RunProcess(false, selectedEncryptionMethod, key, ref textToWorkOn, ref resultText);
                                                DateiSchreiben(resultText, destPath);
                                                destPathSelection = false;
                                                sourcePathSelection = false;
                                                encDecActive = false;
                                            }
                                            else
                                            {
                                                //Nichts
                                            }
                                        }
                                        else
                                        {
                                            destPathSelection = false;
                                        }
                                    } while (destPathSelection);
                                }
                                else
                                {
                                    sourcePathSelection = false;
                                }
                            } while (sourcePathSelection);
                        }
                        else if (selectedMode == 2)
                        {
                            encDecActive = false;
                        }
                        else
                        {
                            //Nichts
                        }
                    } while (encDecActive);
                }
                else if (selectedEncryptionMethod == 1)
                {
                    encDecActive = true;
                    do
                    {
                        selectedMode = ShowMenu(ref encryptionDecryption, "Wollen sie ver- oder entschlüsseln?");
                        if (selectedMode == 0)
                        {
                            sourcePathSelection = true;
                            do
                            {
                                if (InputMaskPath(true, true, ref sourcePath))
                                {
                                    DateiEinlesen(ref textToWorkOn, sourcePath);
                                    destPathSelection = true;
                                    do
                                    {
                                        if (InputMaskPath(false, true, ref destPath))
                                        {
                                            if (InputMaskKey(selectedEncryptionMethod, ref key))
                                            {
                                                RunProcess(true, selectedEncryptionMethod, key, ref textToWorkOn, ref resultText);
                                                DateiSchreiben(resultText, destPath);
                                                destPathSelection = false;
                                                sourcePathSelection = false;
                                                encDecActive = false;
                                            }
                                            else
                                            {
                                                //Nichts
                                            }
                                        }
                                        else
                                        {
                                            destPathSelection = false;
                                        }
                                    } while (destPathSelection);
                                }
                                else
                                {
                                    sourcePathSelection = false;
                                }
                            } while (sourcePathSelection);
                        }
                        else if (selectedMode == 1)
                        {
                            sourcePathSelection = true;
                            do
                            {
                                if (InputMaskPath(true, false, ref sourcePath))
                                {
                                    DateiEinlesen(ref textToWorkOn, sourcePath);
                                    destPathSelection = true;
                                    do
                                    {
                                        if (InputMaskPath(false, false, ref destPath))
                                        {
                                            if (InputMaskKey(selectedEncryptionMethod, ref key))
                                            {
                                                RunProcess(false, selectedEncryptionMethod, key, ref textToWorkOn, ref resultText);
                                                DateiSchreiben(resultText, destPath);
                                                destPathSelection = false;
                                                sourcePathSelection = false;
                                                encDecActive = false;
                                            }
                                            else
                                            {
                                                //Nichts
                                            }
                                        }
                                        else
                                        {
                                            destPathSelection = false;
                                        }
                                    } while (destPathSelection);
                                }
                                else
                                {
                                    sourcePathSelection = false;
                                }
                            } while (sourcePathSelection);
                        }
                        else if (selectedMode == 2)
                        {
                            encDecActive = false;
                        }
                        else
                        {
                            //Nichts
                        }
                    } while (encDecActive);
                }
                else if (selectedEncryptionMethod == 2)
                {
                    encDecActive = true;
                    do
                    {
                        selectedMode = ShowMenu(ref encryptionDecryption, "Wollen sie ver- oder entschlüsseln?");
                        if (selectedMode == 0)
                        {
                            sourcePathSelection = true;
                            do
                            {
                                if (InputMaskPath(true, true, ref sourcePath))
                                {
                                    DateiEinlesen(ref textToWorkOn, sourcePath);
                                    destPathSelection = true;
                                    do
                                    {
                                        if (InputMaskPath(false, true, ref destPath))
                                        {
                                            if (InputMaskKey(selectedEncryptionMethod, ref key))
                                            {
                                                RunProcess(true, selectedEncryptionMethod, key, ref textToWorkOn, ref resultText);
                                                DateiSchreiben(resultText, destPath);
                                                destPathSelection = false;
                                                sourcePathSelection = false;
                                                encDecActive = false;
                                            }
                                            else
                                            {
                                                //Nichts
                                            }
                                        }
                                        else
                                        {
                                            destPathSelection = false;
                                        }
                                    } while (destPathSelection);
                                }
                                else
                                {
                                    sourcePathSelection = false;
                                }
                            } while (sourcePathSelection);
                        }
                        else if (selectedMode == 1)
                        {
                            sourcePathSelection = true;
                            do
                            {
                                if (InputMaskPath(true, false, ref sourcePath))
                                {
                                    DateiEinlesen(ref textToWorkOn, sourcePath);
                                    destPathSelection = true;
                                    do
                                    {
                                        if (InputMaskPath(false, false, ref destPath))
                                        {
                                            if (InputMaskKey(selectedEncryptionMethod, ref key))
                                            {
                                                RunProcess(false, selectedEncryptionMethod, key, ref textToWorkOn, ref resultText);
                                                DateiSchreiben(resultText, destPath);
                                                destPathSelection = false;
                                                sourcePathSelection = false;
                                                encDecActive = false;
                                            }
                                            else
                                            {
                                                //Nichts
                                            }
                                        }
                                        else
                                        {
                                            destPathSelection = false;
                                        }
                                    } while (destPathSelection);
                                }
                                else
                                {
                                    sourcePathSelection = false;
                                }
                            } while (sourcePathSelection);
                        }
                        else if (selectedMode == 2)
                        {
                            encDecActive = false;
                        }
                        else
                        {
                            //Nichts
                        }
                    } while (encDecActive);
                }
                else if (selectedEncryptionMethod == 3)
                {
                    menuActive = false;
                }
                else
                {
                    //Nichts
                }
            } while (menuActive);
        }
    }
}