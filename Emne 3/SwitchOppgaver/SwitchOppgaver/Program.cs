using System;

namespace SwitchOppgaver
{
    class SwitchDay
    {  
        static private void WhichDay(){
        Console.WriteLine("Enter Day Number: ");
        var day= Convert.ToInt32(Console.ReadLine());

        var WhichDay = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day",
        };
        Console.WriteLine($"{WhichDay}");
        }

        class Run
        {
            static void Main()
            {
                WhichDay();
            }
        }
    }   
}