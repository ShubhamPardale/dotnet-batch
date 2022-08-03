using System;
using System.Text;

namespace Strings
{
    class AddStrings
    {
        public static void Main(string[] args)
        {
            string string1 ="Hello";
            string string2 ="World";
            Strings.StringConcatenation.concat(string1,string2);
            Strings.Stringbuilder.Add(string1,string2);
        } 
    }

    class StringConcatenation
    {
        public static void concat(string s1,string s2) 
        {
            string string1 = s1;
            string string2 = s2;
            Console.WriteLine("Result of concatenation: "+(string1+" "+string2));
        }
    }

    class Stringbuilder
    {
        public static void Add(string s1,string s2) 
        {
            StringBuilder addword = new StringBuilder(s1);
            addword.Append(" "+s2);
            Console.WriteLine("Result of Stringbuilder: "+addword);
        }
    }
}