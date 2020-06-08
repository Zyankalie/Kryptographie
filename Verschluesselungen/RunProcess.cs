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
                    break;
                case 2:
                    break;
                default:
                    //Nichts
                    break;
            }
        }
    }
}

