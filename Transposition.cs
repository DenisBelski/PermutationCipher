using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationCipher
{
    internal class Transposition
    {
        private int[] key = null;

        public void SetKey(int[] currentKey)
        {
            key = new int[currentKey.Length];

            for (int i = 0; i < currentKey.Length; i++)
            {
                key[i] = currentKey[i];
            }
        }

        public void SetKey(string[] currentKey)
        {
            key = new int[currentKey.Length];

            for (int i = 0; i < currentKey.Length; i++)
            {
                key[i] = Convert.ToInt32(currentKey[i]);
            }
        }

        public void SetKey(string currentKey)
        {
            SetKey(currentKey.Split(' '));
        }

        public string Encrypt(string input)
        {
            for (int i = 0; i < input.Length % key.Length; i++)
            {
                input += input[i];
            }

            string result = "";

            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                {
                    transposition[key[j] - 1] = input[i + j];
                }

                for (int j = 0; j < key.Length; j++)
                {
                    result += transposition[j];
                }
            }

            return result;
        }

        public string Decrypt(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                {
                    transposition[j] = input[i + key[j] - 1];
                }

                for (int j = 0; j < key.Length; j++)
                {
                    result += transposition[j];
                }
            }

            return result;
        }
    }
}
