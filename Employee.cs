using System;

namespace Employee
{
    class Details
    {
        public static void Main(string[] args)
        {
            string[] name = {"Max","Zoro","Luffy"};
            string[] address = {"Andheri","Kurla","Panvel"};
            Employee.Display.display(name,address);
        }
    }

    class Display
    {
        public static void display(string[] name,string[] address)
        {
            for(int i=0;i<name.Length;i++)
            {
                Console.WriteLine("Name: "+name[i]+" | Address: "+address[i]);
            }
        }
    }
}