using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_and_Date_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.Write("Insert date here (D/M/Y): ");


            string sDate = Console.ReadLine();

            while (!DateTime.TryParse(sDate, out today))
            {
                Console.WriteLine("Please enter valid date in this form (D/M/Y)");
                sDate = Console.ReadLine();
            }

            DateTime userDate = DateTime.Parse(sDate);

            TimeSpan elapsed;

            elapsed = DateTime.Now.Subtract(userDate);

            Console.WriteLine(Math.Abs(elapsed.TotalDays));

            Console.ReadLine();
        }
    }
}
