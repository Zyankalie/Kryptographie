using System.IO;
using System.Text;

namespace Kryptographie
{
    partial class main
    {
        static void CaesarVerschluesseln(string text, ref string verschluesselt, int key)
        {
            int tmpVerschluesselt;
            for (int i = 0; i < text.Length; i++)
            {
                tmpVerschluesselt = text[i] % 128 + key;
                tmpVerschluesselt = tmpVerschluesselt < 30 ? tmpVerschluesselt + 30 : tmpVerschluesselt;
                verschluesselt += (char)tmpVerschluesselt;
            }
        }
    }
}