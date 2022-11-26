using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitution_Cyphers
{
    internal class ROT13
    {
        public string Encrypt(string text)
        {
            string result = "";
            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char UpperLower = char.IsUpper(character) ? 'A' : 'a';
                    result += (char)((((character + 13 + 26) - UpperLower) % 26) + UpperLower);
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }

        public string Decrypt(string text)
        {
            string result = "";
            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char UpperLower = char.IsUpper(character) ? 'A' : 'a';
                    result += (char)((((character - 13 + 26) - UpperLower) % 26) + UpperLower);
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }
    }
}
