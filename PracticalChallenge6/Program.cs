using Microsoft.VisualBasic;
using System.Globalization;

namespace PracticalChallenge6;

class Challenge6
{
    static void Main()
    {
        Console.WriteLine("Type an Day:");
        var day = Console.ReadLine();

        Console.WriteLine("Type an Month:");
        var month = Console.ReadLine();

        Console.WriteLine("Type an Year:");
        var year = Console.ReadLine();

        var date = (day + "/" + month + "/" + year);

        //FULL DATE
      
        DateTime NewDate = Convert.ToDateTime(date);
        TimeSpan NewTime = new TimeSpan(0, 5, 20, 10);
        DateTime NewDateWithTime = NewDate.Add(NewTime);
        var NewDateWithTimeFinal = NewDateWithTime.ToString("dddd, dd MM yyyy HH:mm:ss");

        Console.WriteLine("Full Date Time Format");
        Console.WriteLine(NewDateWithTimeFinal);

        // DATE ONLY 

        Console.WriteLine("Date only Format");
        Console.WriteLine(date);

        // 24 H FORMAT

        Console.WriteLine("Time 24H Format");
        var JustTime = NewDateWithTime.ToString("HH:mm:ss");
        Console.WriteLine(JustTime);

        // DATE WITH MONTH TEXT

        Console.WriteLine("Date and Time with Text Month");
        var DateWithMonthText = NewDateWithTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine(DateWithMonthText);
    }
}