using CodingAssignmentsWeek1.Solutions;

namespace CodingAssignmentsWeek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test CollatzSequence
            Console.Write("Please Enter the first positive integer (a): ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Please Enter the second positive integer (b): ");
            int b = int.Parse(Console.ReadLine()!);

            string collatzResult = Collatz.CompareCollatzSteps(a, b);
            Console.WriteLine($"The integer that takes fewer steps to reach 1 is: {collatzResult}");

            // Test ReverseAndConcatenate
            Console.Write("Enter an integer to reverse and concatenate: ");
            int numberToReverse = int.Parse(Console.ReadLine()!);
            string reversedResult = ReverseAndConcatenate.Perform(numberToReverse);
            Console.WriteLine($"Reversed and concatenated result: {reversedResult}");

            // Test Uncensor
            Console.Write("Enter the censored string: ");
            string censoredString = Console.ReadLine()!;

            Console.Write("Enter the vowels string: ");
            string vowels = Console.ReadLine()!;

            string uncensoredResult = Uncensor.Perform(censoredString, vowels);
            Console.WriteLine($"The uncensored string is: {uncensoredResult}");

            // Test AlmostPalindrome
            Console.Write("Enter a string to check if it's an almost-palindrome: ");
            string palindromeCheck = Console.ReadLine()!;

            bool palindromeResult = AlmostPalindrome.IsAlmostPalindrome(palindromeCheck);
            Console.WriteLine($"Is the string an almost-palindrome? {palindromeResult}");

            // Test TranslateWord
            Console.Write("Enter a word to translate to Pig Latin: ");
            string word = Console.ReadLine()!;
            string translatedWord = PigLatinTranslator.TranslateWord(word);
            Console.WriteLine($"Translated word: {translatedWord}");

            // Test TranslateSentence
            Console.Write("Enter a sentence to translate to Pig Latin: ");
            string sentence = Console.ReadLine()!;
            string translatedSentence = PigLatinTranslator.TranslateSentence(sentence);
            Console.WriteLine($"Translated sentence: {translatedSentence}");

        }
    }
}
