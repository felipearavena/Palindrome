using System;

class Program
{
    static void Main(string[] args)
    {

        string[] array =
            {
                "abcba",
                "abcde",
                "Mr owl ate my metal worm",
                "Never Odd Or Even",
                "Never Even Or Odd"
            };

        foreach (string value in array)
        {
            if (IsPalindrome(value))
            {
                Console.WriteLine($"'{value}' Is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{value}' Is not a palindrome.");
            }
        }

    }

    static bool IsPalindrome(string input)
    {
        //Convert input to lowercase and remove non-alphabetic characters
        string converInput = ConverText(input);

        //Check if input is a palindrome
        int i = 0;
        int j = converInput.Length - 1;

        //runs through the flow
        while (i < j)
        {
            if (converInput[i] != converInput[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

    static string ConverText(string input)
    {
        //Convert to lowercase and remove non-alphabetic characters
        string normalized = "";
        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                normalized += c;
            }
        }
        return normalized;
    }
}
