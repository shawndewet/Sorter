using System;
using System.Linq;

namespace SorterLibrary
{
    public class Sorter
    {
        public string SortBuiltIn(string input)
        {
            var strippedString = StripPunctuation(input.ToLower());
            var sortedStringArray = strippedString.ToCharArray().OrderBy(c => c);
            return string.Concat(sortedStringArray);
        }

        /// <summary>
        /// This uses the Insertion Sort algorithm, which my tests have shown to be the quickest,
        ///   although I know QuickSort is theoretically supposed to be quicker.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The input string sorted ascending</returns>
        public string SortHandCoded(string input)
        {
            var strippedString = StripPunctuation(input.ToLower());
            var charArray = strippedString.ToCharArray();

            for (int i = 1; i < charArray.Length; i++)
            {
                var temp = charArray[i];
                var j = i - 1;
                while (j >= 0 && charArray[j] > temp)
                {
                    charArray[j + 1] = charArray[j];
                    j--;
                }
                charArray[j + 1] = temp;
            }
            return string.Concat(charArray);
        }

        private string StripPunctuation(string input)
        {
            //Regex to remove all non-alphanumeric characters
            System.Text.RegularExpressions.Regex TitleRegex = new
            System.Text.RegularExpressions.Regex("[^a-z0-9]+",
            System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            string ParsedString = TitleRegex.Replace(input, String.Empty);

            return ParsedString;
        }
    }
}
