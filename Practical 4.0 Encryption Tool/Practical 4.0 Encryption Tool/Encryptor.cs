using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4._0_Encryption_Tool
{
    public enum Algorithm
    {
        ROT13,
        StringReverse
    }

    class Encryptor
    {
        IEncryptionAlgorithm encryptor;

        public Encryptor()
        {
            SetAlgorithm(Algorithm.ROT13);
        }

        public string Encrypt(string input)
        {
            return encryptor.Encrypt(input);
        }

        public string Decrypt(string input)
        {
            return encryptor.Decrypt(input);
        }

        public void SetAlgorithm(Algorithm alGore)
        {
            switch (alGore)
            {
                case Algorithm.ROT13:
                    encryptor = new ROT13();
                    break;
                case Algorithm.StringReverse:
                    encryptor = new StringReverse();
                    break;
            }
        }
    }
}
