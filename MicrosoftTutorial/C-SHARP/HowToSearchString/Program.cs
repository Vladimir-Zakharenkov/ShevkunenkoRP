using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace HowToSearchString
{
    /*
     
    You can use two main strategies to search for text in strings.Methods of the String class
    search for specific text.Regular expressions search for patterns in text.

    The string type, which is an alias for the System.String class, provides a number of
    useful methods for searching the contents of a string. Among them are
    Contains, StartsWith, EndsWith, IndexOf, LastIndexOf.
    The System.Text.RegularExpressions.Regex class provides a rich vocabulary to search
    for patterns in text.
    In this article, you learn these techniques and how to choose the best method
    for your needs.

    */

    internal class Program
    {
        static void Main(string[] args)
        {
            // Does a string contain text?

            // The String.Contains, String.StartsWith, and String.EndsWith methods search
            // a string for specific text. The following example shows each of these methods
            // and a variation that uses a case-insensitive search: 

            string factMessage = "Extension methods have all the capabilities of regular static methods.";

            // Write the string and include the quotation marks.
            Console.WriteLine($"\"{factMessage}\"");
            Console.WriteLine();

            // Simple comparisons are always case sensitive!
            bool containsSearchResult = factMessage.Contains("extension");
            Console.WriteLine($"Contains \"extension\"? {containsSearchResult}");

            // For user input and strings that will be displayed to the end user,
            // use the StringComparison parameter on methods that have it to specify
            // how to match strings.
            bool ignoreCaseSearchResult = factMessage.StartsWith("extension", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Starts with \"extension\"? {ignoreCaseSearchResult} (ignoring case)");
            Console.WriteLine();

            bool endsWithSearchResult = factMessage.EndsWith(".", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Ends with '.'? {endsWithSearchResult}");
            Console.WriteLine();

            bool contains2SearchResult = factMessage.Contains("Hods", System.StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine($"Contains 'Hods'? {contains2SearchResult} (ignoring case)");
            Console.WriteLine();

            // Where does the sought text occur in a string?

            // The IndexOf and LastIndexOf methods also search for text in strings.
            // These methods return the location of the text being sought.
            // If the text isn't found, they return -1. The following example
            // shows a search for the first and last occurrence of the word "methods"
            // and displays the text in between

            string factMessage2 = "Extension methods have all the capabilities of regular static methods.";

            // Write the string and include the quotation marks.
            Console.WriteLine($"\"{factMessage2}\"");
            Console.WriteLine(
                );
            // This search returns the substring between two strings, so
            // the first index is moved to the character just after the first string.
            int first = factMessage2.IndexOf("methods") + "methods".Length;
            int last = factMessage2.LastIndexOf("methods");
            string str2 = factMessage2.Substring(first, last - first);
            Console.WriteLine($"Substring between \"methods\" and \"methods\": '{str2}'");
            Console.WriteLine();

            // Finding specific text using regular expressions

            // The System.Text.RegularExpressions.Regex class can be used to search strings.
            // These searches can range in complexity from simple to complicated text patterns.

            // The following code example searches for the word "the" or "their" in a sentence,
            // ignoring case. The static method Regex.IsMatch performs the search.
            // You give it the string to search and a search pattern.
            // In this case, a third argument specifies case-insensitive search.
            // For more information, see System.Text.RegularExpressions.RegexOptions.

            //  Pattern     Meaning
            //  the         match the text "the"
            //  (eir)?      match 0 or 1 occurrence of "eir"
            //  \s          match a white-space character

            string[] sentences =
            {
                "Put the water over there.",
                "They're quite thirsty.",
                "Their water bottles broke."
            };

            string sPattern = "the(ir)?\\s";

            foreach (string s in sentences)
            {
                Console.Write($"{s}");

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($" (match for '{sPattern}' found)");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            // The string methods are usually better choices when you are searching for
            // an exact string. Regular expressions are better when you are searching for
            // some pattern in a source string.


            // Does a string follow a pattern?

            // The following code uses regular expressions to validate the format of each string
            // in an array. The validation requires that each string have the form
            // of a telephone number in which three groups of digits are separated by dashes,
            // the first two groups contain three digits, and the third group contains
            // four digits. The search pattern uses the regular expression
            // ^\\d{3}-\\d{3}-\\d{4}$.
            // For more information, see Regular Expression Language - Quick Reference.

            //  Pattern         Meaning
            //  ^               matches the beginning of the string
            //  \d{3}           matches exactly 3 digit characters
            //  -               matches the '-' character
            //  \d{4}           matches exactly 4 digit characters
            //  $               matches the end of the string

            string[] numbers =
            {
                "123-555-0190",
                "444-234-22450",
                "690-555-0178",
                "146-893-232",
                "146-555-0122",
                "4007-555-0111",
                "407-555-0111",
                "407-2-5555",
                "407-555-8974",
                "407-2ab-5555",
                "690-555-8148",
                "146-893-232-"
            };

            string sPattern2 = "^\\d{3}-\\d{3}-\\d{4}$";

            foreach (string s in numbers)
            {
                Console.Write($"{s,14}");

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern2))
                {
                    Console.WriteLine(" - valid");
                }
                else
                {
                    Console.WriteLine(" - invalid");
                }
            }

            // This single search pattern matches many valid strings.
            // Regular expressions are better to search for or validate against a pattern,
            // rather than a single text string.
        }
    }
}