using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4._0_Encryption_Tool
{
    class StringReverse : IEncryptionAlgorithm
    {
        public string Decrypt(string input)
        {
            return Reverse(input);
        }

        public string Encrypt(string input)
        {
            return Reverse(input);
        }

        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
