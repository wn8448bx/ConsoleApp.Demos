using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo;

public abstract class Polygon
{
    public double Width { get; set; }

    public abstract double Area(); //with this abstract method, it doesn't want to know how to use it. Anything that 
    //inherits from Polygon, must have Area() and define how to use it

    public virtual string GetShapeName()
    {
        throw new NotImplementedException();
    }
}
