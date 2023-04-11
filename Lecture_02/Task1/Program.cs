// See https://aka.ms/new-console-template for more information
// Task 1
// Write a console application that accepts a string and outputs to the string a
// decision for each word of the string, whether it is a palindrome.
// Ignore letter case and hyphens.

using System.Text.RegularExpressions;

string inputString()
{
    Console.WriteLine("Input source string:");

    return Console.ReadLine();
}

void CheckIfPalindrome(string word)
{
    char[] charArray = word.ToCharArray();
    string reversedStr;

    Array.Reverse(charArray);
    reversedStr = new string(charArray);

    if (word.Any(Char.IsLetter))
    {
        if (word.Equals(reversedStr, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("{0} - palindrome", word);
        else
            Console.WriteLine("{0} - not palindrome", word);
    }
}

void SplitString(string inputStr)
{
    string[] words;

    words = Regex.Split(inputStr, @"[\s,.]+");

    foreach (string word in words)
    {
        CheckIfPalindrome(word);
    }
}

// string sourceStr = "Hgggh, jsj lkks, a lil-lil – lop. ds43-";

string sourceStr2 = inputString();
SplitString(sourceStr2);

Console.ReadKey();
