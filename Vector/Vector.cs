using System.Runtime.CompilerServices;
using System;
namespace Vector;

public struct Vector
{
    
    public double Magnitude;


    public double X;

    public double Y;

    public double Direction;

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
        Direction=Math.Atan2(Y,X)*180/Math.PI;
        Magnitude=Math.Sqrt(x*x+y*y);
    }

}