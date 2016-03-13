using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4._0_Encryption_Tool
{
    interface IEncryptionAlgorithm
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }
}
