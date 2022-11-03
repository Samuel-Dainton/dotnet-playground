using Humanizer;
using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment.

            // Write will put everything together.
            Console.Write("Congratulations!");
            Console.Write(" ");
            Console.Write("You wrote your first lines of code!");

            // WriteLine will seperate to another line.
            Console.WriteLine(" ");
            Console.WriteLine("This is the first line.");

            Console.WriteLine("This is the second line.");

            Console.Write("This is");
            Console.Write(" the");
            Console.Write(" third line.");

            Console.WriteLine("Quantities:");
            HumanizeQuantities();

            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }
        static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }

        static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}
