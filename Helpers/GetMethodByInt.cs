using System.Runtime.Remoting.Messaging;

namespace Kryptographie
{
    partial class main
    {
        static string GetMethodByInt(int id)
        {
            switch (id)
            {
                case 0:
                    return "Caesar";
                case 1:
                    return "Vigenere";
                case 2:
                    return "OTP";
                default:
                    return "";
            }
        }
    }
}