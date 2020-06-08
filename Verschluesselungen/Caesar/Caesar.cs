using System;

namespace Kryptographie
{
    partial class main
    {
        static void Caesar(bool encDec, string key, ref string textToWorkOn, ref string resultText)
        {
            if (encDec)
            {
                CaesarVerschluesseln(textToWorkOn, ref resultText, Convert.ToInt32(key));
            }
            else
            {
                CaesarEntschluesseln(textToWorkOn, ref resultText, Convert.ToInt32(key));
            }
        }
    }
}