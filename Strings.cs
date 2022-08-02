using System;
using System.Text;

namespace Stringbuilder
{
    class AddStrings
    {
        public static void Main(string[] args) 
        {
            StringBuilder addword = new StringBuilder("My");
            addword.Append(" name");
            addword.Append(" is");
            addword.Append(" Shubham Pardale");
            Console.WriteLine(addword);
        }
    }
}