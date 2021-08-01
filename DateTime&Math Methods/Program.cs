using System;

namespace DateTime_Math_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddMilliseconds(35));
            Console.WriteLine(DateTime.Now.AddSeconds(55));
            Console.WriteLine(DateTime.Now.AddMinutes(15));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddYears(30));

            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //01
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sun
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Sunday

            Console.WriteLine(DateTime.Now.ToString("MM")); //08
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Aug
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //August

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyy")); //2021


            //Math Class

            Console.WriteLine(Math.Abs(-25)); //absolute value
            Console.WriteLine(Math.Cbrt(27)); //cube root
            Console.WriteLine(Math.CopySign(1,-5)); 
            Console.WriteLine(Math.Cos(90)); //cos
            Console.WriteLine(Math.E); //e constant
            Console.WriteLine(Math.Exp(2)); //power of e
            Console.WriteLine(Math.Log10(10)); // log on Base-10
            Console.WriteLine(Math.Sqrt(16)); //square root
            Console.WriteLine(Math.Round(15.67)); //rounding
            Console.WriteLine(Math.Pow(2,5)); //power
            Console.WriteLine(Math.Max(15,35)); //the max of two numbers



        }
    }
}
