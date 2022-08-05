using System;
using System.Text;
using System.Collections.Generic;
    

namespace lists
{
    class maxnum
    {
        public static void Main(string[] args)
        {
            
            lists.Array.arrays();
            lists.ArrayList.arraylists();
            lists.LinkedList.linkedlists();
        }
        
    }
    class Array
    {
        public static void arrays()
        {
            int[] array1 = {15,10,23,7,50,44,49,65,76,25};
            int max =0;
            for (int i = 0; i < 9; i++)
            {
                if (array1[i]>array1[i+1])
                {
                    max=array1[i];
                }
            }
            Console.WriteLine(max);
        }
    }

    class ArrayList
    {
        public static void arraylists()
        {
            List<int> arraylist = new List<int>(){15,10,23,7,50,44,49,65,77,25};
            int max =0;
            for (int i = 0; i < 9; i++)
            {
                if (arraylist[i]>arraylist[i+1])
                {
                    max=arraylist[i];
                }
            }
            Console.WriteLine(max);
        }
    }

    class LinkedList
    {
       public static void linkedlists()
       {
            LinkedList<int> linkedlist =new LinkedList<int>();
            linkedlist.AddLast(15);
            linkedlist.AddLast(10);
            linkedlist.AddLast(23);
            linkedlist.AddLast(7);
            linkedlist.AddLast(50);
            linkedlist.AddLast(44);
            linkedlist.AddLast(49);
            linkedlist.AddLast(65);
            linkedlist.AddLast(78);
            linkedlist.AddLast(25);
            int max =0;
            foreach(int i in linkedlist)
            {
                if (i>max)
                {
                    max=i;
                }
               
            }
            Console.WriteLine(max);
       }
    }
}