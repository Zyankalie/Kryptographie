using System.IO;
using System.Text;

namespace Kryptographie
{
    partial class main
    {
        static void DateiEinlesen(ref string text, string dateiPfad)
        {
            FileStream FS = new FileStream(dateiPfad, FileMode.Open, FileAccess.Read);            
            StreamReader SR = new StreamReader(FS, Encoding.UTF8);

            text = SR.ReadToEnd();

            SR.Close();
            FS.Close();
        }
    }
}