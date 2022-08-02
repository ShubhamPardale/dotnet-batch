using System;

namespace Math
{
    class Operations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Math.Sum.Sums(n1,n2);
            Math.substract.substracts(n1,n2);
            Math.Multipy.Multipys(n1,n2);
            Math.Divide.Divides(n1,n2);

        }
    }

    public class Sum
    {
        public static void Sums(int n1, int n2)
        {
            Console.WriteLine("Addition of numbers : "+ (n1+n2));
        }
    }

    public class substract
    {
        public static void substracts(int n1, int n2)
        {
            Console.WriteLine("Addition of numbers : "+ (n1-n2));
        }
    }

    public class Multipy
    {
        public static void Multipys(int n1, int n2)
        {
            Console.WriteLine("Addition of numbers : "+ (n1*n2));
        }
    }

    public class Divide
    {
        public static void Divides(int n1, int n2)
        {
            Console.WriteLine("Addition of numbers : "+ (n1/n2));
        }
    }

}