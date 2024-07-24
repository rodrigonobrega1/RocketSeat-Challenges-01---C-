using System.Text.RegularExpressions;

namespace PracticalChallenge4;

class Challenge4
{
    static void Main()
    {
        string text1 = "Type something...";
        Console.WriteLine(text1);
        string result1 = Console.ReadLine();

        string result1trimed = Regex.Replace(result1, @"\s", "");

        Console.WriteLine(result1trimed.Length);
    }
}