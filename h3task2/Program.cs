using Microsoft.VisualBasic;

namespace h3task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of month");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 2)
            {
                Console.WriteLine("Enter a year");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0 &&(year % 100 != 0 || year % 400 == 0))
                {
                    Console.WriteLine("There are 29 days in this month");
                }
                else { Console.WriteLine("There are 28 days in this month"); };
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7
                || month == 8 || month == 10 || month == 12) 
            {
                Console.WriteLine("There are 31 days in this month");
            }
            else if(month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("There are 30 days in this month"); 
            }
            else { Console.WriteLine("this month doesn't exist"); }
        }
    }
}