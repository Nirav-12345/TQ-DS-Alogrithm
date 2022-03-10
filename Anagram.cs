using System;

namespace Anagram;

class program
{
    public static void Main(string[] args)
    {
        string str1 = "earth";
        string str2 = "heart";

        char[] ch1 = str1.ToLower().ToCharArray();

        char[] ch2 = str2.ToLower().ToCharArray();

        Array.Sort(ch1);
        Array.Sort(ch2);
        string val1 = new string(ch1);
        string val2 = new string(ch2);

        if (val1==val2)
        {
            Console.WriteLine("Anagram");
        }

        else { Console.WriteLine("not Anagram"); }

    }
}