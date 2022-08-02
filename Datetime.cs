using System;

namespace Timestamp
{
    class Date
    {
        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2022,3,17,8,30,10);
            DateTime date2 = new DateTime(2022,12,14,10,50,00);
            Timestamp.Difference.Diff(date1,date2);
        }
    }
    class Difference
    {
        public static void Diff(DateTime t1,DateTime t2)
        {
            TimeSpan interval = t2-t1;
            
            Console.WriteLine("The Difference is " + interval);
        }
    }
}