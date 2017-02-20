
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverride
{
    class CalculateArea
    {
        public double pie = 3.14;
        public double width = 0;
        public double length = 0;
        public double side = 0;
        public virtual void Area()
        {

        }
    }
    class Rectangle : CalculateArea
    {
        public override void Area()
        {
            Console.WriteLine("--------- Area Of Rectangle ---------");
            Console.WriteLine("Please enter the values of width Find out area of Rectangle");
            var valuewidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the values of length Find out area of Rectangle");
            var valuelength = Convert.ToInt32(Console.ReadLine());
            var AreaofRectangle = valuewidth * valuelength;
            Console.WriteLine("Area of Rectangle:" + AreaofRectangle);

        }
    }
    class Square : CalculateArea
    {
        public override void Area()
        {
            Console.WriteLine("--------- Area Of Square ---------");
            Console.WriteLine("Please enter the values of Side Find out area of Square");
            var Side = Convert.ToInt32(Console.ReadLine());
            var AreaofSquare = Side * Side;
            Console.WriteLine("Area of Square:" + AreaofSquare);

        }
    }
    class Circle : CalculateArea
    {

        public override void Area()
        {
            Console.WriteLine("--------- Area Of Circle ---------");
            Console.WriteLine("Please enter the values of Radius Find out area of circle");
            var values = Convert.ToInt32(Console.ReadLine());
            var Areaofcircle = pie * (values * values);
            Console.WriteLine("Area of Circle:" + Areaofcircle);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            bool _continue = true;
            while (_continue)
            {
                Console.WriteLine("Please select the options below to which you would like to find out area:\n 1.Circle \n 2.Square \n 3.Rectangle");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Circle Cir = new Circle();
                        Cir.Area();
                        _continue = false;
                        break;
                    case 2:
                        Square Sq = new Square();
                        Sq.Area();
                        _continue = false;
                        break;
                    case 3:
                        

                        Rectangle Rec = new Rectangle();
                        Rec.Area();
                        _continue = false;
                        break;
                    default:
                        Console.WriteLine("Please enter the correct option");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
