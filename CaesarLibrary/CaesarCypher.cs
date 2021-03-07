using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CaesarLibrary
{
    public static class CaesarCypher
    {
        
        public static char Encrypt(char ch, int offset)
        {
            if (!char.IsLetter(ch))
                return ch;
            else if (Char.IsUpper(ch))
               return (char)((ch + offset - 65) % 26 + 65);
            else
               return (char)((ch + offset - 97) % 26 + 97);
        }

        public static char Decrypt(char ch, int offset)
        {
            return Encrypt(ch, 26 - offset % 26);
        }

        public static string Encrypt(string message, int offset)
        {

            if (offset < 0)
            {
                return Decrypt(message, Math.Abs(offset % 26));
            }
            else if(offset == 0)
            {
                return message;
            }
            StringBuilder result = new StringBuilder();
            foreach (char ch in message)
            {
                result.Append(Encrypt(ch, offset%26 ));
            }

            return result.ToString();
        }


        public static string Decrypt(string message, int offset)
        {
            if (offset < 0)
            {
                return Encrypt(message, Math.Abs(offset % 26));
            }
            else if (offset == 0)
            {
                return message;
            }
            return Encrypt(message, 26 - offset % 26);
        }
    }
}
