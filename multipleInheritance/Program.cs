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
    }
    
    class secondBase : baseClass
    {
        protected float height;
        // setting height
        public void setHeight(float hei)
        {
            height = hei;
        }
    }

    class derivedClass : secondBase, baseClass   // multiple inheritance as derived class inherits from two other classes
    {
        public float getArea()
        {
            return (length * width * height);
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
            obj.getArea(); // expected output 2*2*2=8
            Console.Out.WriteLine("Area = " + obj.getArea());
            Console.ReadLine();
        }
    }
}
