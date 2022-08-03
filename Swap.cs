using System;

namespace Swap
{
    class String
    {
        public static void Main(string[] args)
        {
            string string1="Hello";
            string string2="World";
            
            string2=string2+string1;
            string1 = string2.Substring(0, string2.Length - string1.Length);
            string2 = string2.Substring(string1.Length);

           
            Console.WriteLine(string1);
            Console.WriteLine(string2);
        }
    }

}