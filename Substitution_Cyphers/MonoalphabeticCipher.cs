using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitution_Cyphers
{
    internal class MonoalphabeticCipher
    {
        public string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random rnd= new Random();
        public char[] shuffledAlphabet;
        public MonoalphabeticCipher()
        {
            this.shuffledAlphabet = Shuffle(Alphabet);
        }

        public char[] Shuffle(string alphabet)
        {
            char[] result=alphabet.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                int random = rnd.Next(alphabet.Length);
                (result[i], result[random]) = (result[random], result[i]);
            }

            return result;
        }

        public string Encrypt(string text)
        {
            string result = "";
            foreach (var character in text)
            {
                if (char.IsLetter(character))
                {
                    if (char.IsUpper(character))
                    {
                        result += shuffledAlphabet[character-'A'];
                    }
                    else
                    {
                        result += char.ToLower(shuffledAlphabet[character - 'a']);
                    }
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
            foreach (var character in text)
            {
                if (char.IsLetter(character))
                {
                    if (char.IsUpper(character))
                    {
                        result += Alphabet.ToCharArray()[Array.IndexOf(shuffledAlphabet, character)];
                    }
                    else
                    {
                        result +=char.ToLower(Alphabet.ToCharArray()[Array.IndexOf(shuffledAlphabet, char.ToUpper(character))]);
                    }
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
