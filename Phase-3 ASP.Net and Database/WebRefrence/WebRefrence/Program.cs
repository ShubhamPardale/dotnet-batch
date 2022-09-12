using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRefrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localhost.Service1 myMathService = new localhost.Service1();
            Console.Write("2 + 4 = {0}", myMathService.Add(2, 4));
        }
    }
}
