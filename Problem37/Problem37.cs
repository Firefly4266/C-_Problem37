using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem37
{

    class SimpleShape
    {
        double pri_width;
        double pri_height;

        public SimpleShape() { width = height = 0.0; } // Default constructor. 

        public SimpleShape(double w, double h)  // Constructor for SimpleShape. 
        {
            width = w;
            height = h;
        }

        public SimpleShape(double x) { width = height = x; }  // Construct object with equal width and height. 

        public double width
        {
            get { return pri_width; }
            set { pri_width = value; }
        }

        public double height
        {
            get { return pri_height; }
            set { pri_height = value; }
        }

        public void showDim()
        {
            Console.WriteLine($"a width of {width} and a height of {height}.\n");
        }
    }

    // A derived class of SimpleShape for triangles. 
    class Triangle : SimpleShape
    {
        string style; // private 

        public Triangle() { style = "null"; } // Default constructor.

        public Triangle(string s, double w, double h) : base(w, h) // Constructor for Triangles
        {
            style = s;
        }

        public double area()
        {
            return width * height / 2;
        }

        public void showStyle()
        {
            Console.WriteLine($"\n The Triangle is a {style} triangle.\n");
        }

    }
    class ColorTriangle : Triangle 
    {
        string color;
        public ColorTriangle(string c, string s, double w, double h) : base(s, w, h)
        {
            color = c;
            var style = s;
        }

        public void showColor()
        {
            Console.WriteLine(color);
        }

    }

    class MyClass37
    {
        public static void Problem37()
        {
            Console.WriteLine(" Welcome to my Shape Inheritance Program!");
            Console.WriteLine("---------------------------------------------------------------------------\n");
            SimpleShape shape1 = new SimpleShape(5, 5);

            Console.Write(" Default settings for a square are ");
            shape1.showDim();

            Triangle tri1 = new Triangle("right", 8.5, 12.25);
            tri1.showStyle();
            Console.Write($" The area of the triangle is {tri1.area()}.\n The triangle has ");
            tri1.showDim();

            Console.Write("\n Enter a new height and width for your square: ");
            int newH = Convert.ToInt16(Console.ReadLine());

            SimpleShape shape2 = new SimpleShape(newH);

            Console.Write("\n The new settings for the square are ");
            shape2.showDim();

            ColorTriangle colorTriangle = new ColorTriangle("blue", "isosceles", 6.3, 18.7);

            //Console.Write($"\n This type of triangel is called ");
            colorTriangle.showStyle();
            Console.Write($" triangel whos dimentions are ");
            colorTriangle.showDim();
            Console.Write($" and has a color of ");
            colorTriangle.showColor();
        }
    }
}
