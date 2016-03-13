using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4._0_Encryption_Tool
{
    class ROT13 : IEncryptionAlgorithm
    {
        public string Decrypt(string input)
        {
            return Rotate13(input);
        }

        public string Encrypt(string input)
        {
            return Rotate13(input);
        }

        public string Rotate13(string input)
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int number = charArray[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                charArray[i] = (char)number;
            }
            return new string(charArray);
        }
    }
}
