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

        public string SortHandCoded(string input)
        {
            throw new NotImplementedException();
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
