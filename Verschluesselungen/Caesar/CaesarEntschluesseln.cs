namespace Kryptographie
{
    partial class main
    {
        static void CaesarEntschluesseln(string verschluesselt, ref string text, int key)
        {
            int tmpEntschluesselt;
            for (int i = 0; i < verschluesselt.Length; i++)
            {
                tmpEntschluesselt = verschluesselt[i] <= 60 ? verschluesselt[i] - 30 : verschluesselt[i];
                tmpEntschluesselt -= key;
                text += (char)tmpEntschluesselt;
            }
        }
    }
}