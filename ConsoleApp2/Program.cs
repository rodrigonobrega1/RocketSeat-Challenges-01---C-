namespace PracticalChallenge2;

class Challenge2
{
    static void Main()
    {
        string text1 = "Whats your first name?";
        Console.WriteLine(text1);
        string result1 = Console.ReadLine();

        string text2 = "Whats your last name?";
        Console.WriteLine(text2);
        string result2 = Console.ReadLine();

        string text3 = "Your fullname is: " + result1 + " " + result2;
        Console.WriteLine(text3);
    }
}