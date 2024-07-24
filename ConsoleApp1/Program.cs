namespace PracticalChallenge1;

class Challenge1
{
    static void Main()
    {
        string text1 = "Whats your name?";
        Console.WriteLine(text1);
        string result1 = Console.ReadLine();

        string text2 = "Hello " + result1 + " You are very welcome!";
        Console.WriteLine(text2);
    }
}