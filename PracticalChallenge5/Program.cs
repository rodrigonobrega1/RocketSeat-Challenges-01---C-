namespace PracticalChallenge5;

class Challenge5
{
    static void Main()
    {
        string text1 = "Type your Car registration number";
        Console.WriteLine(text1);
        string CRN = Console.ReadLine();

        string Part1 = CRN.Remove(3);
        string Part2 = CRN.Substring(3);

        Console.WriteLine(Part1);
        Console.WriteLine(Part2);

        bool TrueCondition = CRN.Length == 7 && Part1.All(char.IsLetter) && Part2.All(char.IsNumber);

        if (TrueCondition)
        {

            Console.WriteLine("Registration number is True");
        }
        else
        {
            Console.WriteLine("Your Registration Number is False");
        }
    }
}