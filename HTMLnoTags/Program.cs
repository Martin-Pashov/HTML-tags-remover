using System;
using System.Text.RegularExpressions;

namespace HTMLnoTags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a HTML with tags: ");
            string content = Console.ReadLine();

            string pattern = @"<title>([a-z ]*)</title>";
            Regex regX = new Regex(pattern, RegexOptions.IgnoreCase);

            Match match = regX.Match(content);
            Console.WriteLine($"Title: {match.Groups[1].Value}");
            content = Regex.Replace(content, pattern, "");

            pattern = @"<[^>]*>";

            content = Regex.Replace(content, pattern, "");

            Console.WriteLine("Body:");

            Console.WriteLine(content);
        }
    }
}
