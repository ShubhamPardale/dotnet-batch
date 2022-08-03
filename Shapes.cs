using System;

namespace AreaofShapes
{
    class Area
    {
        public static void Main(string[] args)
        {
            int side1=10;
            int side2=20;
            if(side2==0)
            {
                AreaofShapes.Square.square(side1);    
            }
            else
            {
                AreaofShapes.Rectangle.rectangle(side1,side2);
            }
        }
    }
    class Square
    {
        public static void square(int side1)
        {
            Console.WriteLine("Area of Square is : "+(side1*side1));
        }

    }

    class Rectangle
    {
        public static void rectangle(int side1,int side2)
        {
            Console.WriteLine("Area of Rectangle is : "+(side1*side2));
        } 
        
    }
}