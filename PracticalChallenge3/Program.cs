namespace PracticalChallenge3;

class Challenge3
{
    static void Main()
    {
        string text1 = "Whats your first number?";
        Console.WriteLine(text1);
        double number1 = double.Parse(Console.ReadLine());

        string text2 = "Whats your second number?";
        Console.WriteLine(text2);
        double number2 = double.Parse(Console.ReadLine());

        double SUM = number1 + number2;
        double SUB = number1 - number2;
        double MULT = number2 * number1;
        double DIV = number1 / number2;
        double AVRG = SUM / 2;

        string text3 = "This is the SUM of your numbers: ";
        Console.WriteLine(SUM);

        string text4 = "This is the SUB of your numbers: ";
        Console.WriteLine(SUB);

        string text5 = "This is the DIV of your numbers: ";
        Console.WriteLine(DIV);

        string text6 = "This is the MULT of your numbers: ";
        Console.WriteLine(MULT);

        string text7 = "This is the AVRG of your numbers: ";
        Console.WriteLine(AVRG);
    }
}