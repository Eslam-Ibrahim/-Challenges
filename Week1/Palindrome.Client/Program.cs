using System;
using Palindrome.Domain.Models;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            System.Console.WriteLine("Enter a word: ");
            word = System.Console.ReadLine();
            PalindromeGame pal = new PalindromeGame(word);
            Console.WriteLine($"Is Word Palindrome?: {pal.PlayPalindrome()}");
        }
    }
}
