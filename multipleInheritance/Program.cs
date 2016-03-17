using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    // program >> multiple inheritance
    // similar program as single inheritance but made changes for multiple inheritance
    // length, width in 1st base class
    // height in 2nd base class
    // area in derived class which inherits from two base class 
    // 1st base class
    class baseClass
    {
        protected float length; 
        protected float width;
        protected float height;
        // setting length
        public void setLength(float len)
        {
            length = len;
        }
        // setting width
        public void setWidth(float wid)
        {
            width = wid;
        }
        // setting height
        public void setHeight(float hei)
        {
            height = hei;
        }
    }
    
    /*
    class secondBase : baseClass
    {
        protected float height;
        // setting height
        public void setHeight(float hei)
        {
            height = hei;
        }
    }
     */
    public interface secondBase  // in C# multiple inheritance cannot be done by having 2 base class and 1 derived class so we use interface in C# for inheritance
    {
        float cost(float area);
    }

    class derivedClass : baseClass, secondBase    // multiple inheritance as derived class inherits from two other classes
    {
        public float getArea()
        {
            return (length * width * height);
        }
        public float cost(float area)
        {
            return area * 5; //to test expected cost = 8*5=40
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            derivedClass obj = new derivedClass(); // declare object of derived class to know if it inherits
            obj.setLength(2);
            obj.setWidth(2);
            obj.setHeight(2);
            float area = obj.getArea(); // expected output 2*2*2=8
            Console.Out.WriteLine("Area = " + area);
            Console.Out.WriteLine("Cost = " + obj.cost(area)); // expected cost = 8*5=40
            Console.ReadLine();
        }
    }
}
