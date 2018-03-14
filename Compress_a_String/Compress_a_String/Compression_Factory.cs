using System;
using System.Collections.Generic;
using System.Text;

namespace Compress_a_String
{
    class Compression_Factory
    {
        //Implement a method to perform basic string compression using the counts of repeated characters. For example, the string aabccccaaa would become a2b1c4a3. If the "compressed" string would not become smaller than the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters.

        public string Compress(string input)
        {
            StringBuilder sb = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 0; i < input.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                    sb.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }
            Console.WriteLine(sb);
            return sb.Length < input.Length ? sb.ToString() : input;
        }
    }
}
