using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Date: ");
            Console.WriteLine(thisDay.ToString("d"));
            Console.WriteLine(thisDay.AddYears(10).ToString("d"));//plus 10 years
            Console.Write("Enter the number of years: ");
            string years = Console.ReadLine();
            Int32.TryParse(years, out int j);
            Console.WriteLine(thisDay.AddYears(j).ToString("d"));


        }
    }
}
