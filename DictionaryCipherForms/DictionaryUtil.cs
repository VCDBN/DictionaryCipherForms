using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCipherForms
{
    public static class DictionaryUtil
    {
        public static Dictionary<char, char> encryptionDict = new Dictionary<char, char>();
        public static Dictionary<char, char> decryptionDict = new Dictionary<char, char>();

        public static void GenerateEncryptionDictionary(int shift)
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                char encryptedLetter = (char)(((letter - 'A') + shift) % 26 + 'A');
                encryptionDict[letter] = encryptedLetter;
            }
        }

        public static void GenerateDecryptionDictionary()
        {
            foreach (var entry in encryptionDict)
            {
                decryptionDict[entry.Value] = entry.Key;
            }
        }

    }
}
