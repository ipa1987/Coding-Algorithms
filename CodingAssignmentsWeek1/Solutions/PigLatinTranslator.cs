using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingAssignmentsWeek1.Solutions
{
    public class PigLatinTranslator
    {
        public static string TranslateWord(string word)
        {
            // Regex expression used to match vowels
            string vowels = "AEIOUaeiou";
            string lowerWord = word.ToLower();
            int firstVowelIndex = lowerWord.IndexOfAny(vowels.ToCharArray());

            if (firstVowelIndex == 0)
            {
                // Word starts with a vowel
                return word + "yay";
            }
            else
            {
                // Word starts with a consonant
                string prefix = word.Substring(0, firstVowelIndex);
                string stem = word.Substring(firstVowelIndex);
                string pigLatinWord = stem + prefix + "ay";

                // Preserve original case
                if (char.IsUpper(word[0]))
                {
                    pigLatinWord = char.ToUpper(pigLatinWord[0]) + pigLatinWord.Substring(1).ToLower();
                }

                return pigLatinWord;
            }
        }

        public static string TranslateSentence(string sentence)
        {
            // Regex used to match words and keep punctuation intact
            string pattern = @"(\w+)([\W]*)";
            return Regex.Replace(sentence, pattern, match =>
            {
                string word = match.Groups[1].Value;
                string punctuation = match.Groups[2].Value;

                string translatedWord = TranslateWord(word);
                return translatedWord + punctuation;
            });
        }
    }
}
