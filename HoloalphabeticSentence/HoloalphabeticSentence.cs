using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            
            bool[] mark = new bool[26];
 
        int index = 0;
 
        //To Traverse all characters
        for (int i = 0; i < input.Length; i++)
        {
            // If uppercase character, subtract 'A' to find index.
            if ('A' <= input[i] && 
                    input[i] <= 'Z')
                         
                index = input[i] - 'A';
 
                // If lowercase character, subtract 'a' to find  index.
                
            else if('a' <= input[i] && 
                        input[i] <= 'z')
                             
                index = input[i] - 'a';
 
            // Mark current character
            mark[index] = true;
        }
 
        // Return false if any character is unmarked
        for (int i = 0; i <= 25; i++)
            if (mark[i] == false)
                return (false);
 
        // If all characters were present
        return (true);

        }
    }
}
