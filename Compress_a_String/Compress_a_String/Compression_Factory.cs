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
            //StringBuilder creates a resizable array of all strings, copying them back to a string only when necessary
            StringBuilder sb = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //this keeps track of how many times a letter is displayed
                countConsecutive++;

                //if the next value is equal to null OR if the next character is different than the current
                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    //append input at i to string sb
                    sb.Append(input[i]);
                    //append the number of times a particular letter was seen
                    sb.Append(countConsecutive);
                    //set count to 0 for new letter in string input
                    countConsecutive = 0;
                }
            }
            //output compressed string sb
            Console.WriteLine(sb);
            //if length of sb is less than length of input, return sb -- ELSE return original input
            return sb.Length < input.Length ? sb.ToString() : input;
        }
    }
}
