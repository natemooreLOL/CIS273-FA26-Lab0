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
        Direction=Math.Atan2(y,x)*180/Math.PI;
        Magnitude=Math.Sqrt((x*x)+(y*y));
    }

    public Vector Add(Vector v)
    {
        return new Vector(X+v.X, Y+v.Y);
    }
    public Vector Subtract(Vector v)
    {
        return new Vector(X-v.X,Y-v.Y);
    }
    public double Dot(Vector v)
    {
        return X*v.X+Y*v.Y;
    }
    public double AngleBetween(Vector v)
    {
        return Math.Abs(Direction-v.Direction);
    }
    public Vector Multiply(double Scalar)
    {
        return new Vector(X*Scalar, Y*Scalar);
    }
    public Vector Divide(double Scalar)
    {
        return new Vector(X/Scalar,Y/Scalar);
    }
    public Vector Normalize()
    {
        return new Vector(X/Magnitude,Y/Magnitude);
    }
    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }

    public static Vector Add(Vector v1, Vector v2)
    {
        return v1.Add(v2);
    }
    public static Vector Subtract(Vector v1, Vector v2)
    {
        return v1.Subtract(v2);
    }
    public static double Dot(Vector v1, Vector v2)
    {
        return v1.Dot(v2);
    }
    public static double AngleBetween(Vector v1, Vector v2)
    {
        return v1.AngleBetween(v2);
    }
    public static Vector Multiply(Vector v1, double Scalar)
    {
        return v1.Multiply(Scalar);
    }
    public static Vector Divide(Vector v1, double Scalar)
    {
        return v1.Divide(Scalar);
    }
    public static Vector Normalize(Vector v)
    {
        return v.Normalize();
    }
    public static Vector operator +(Vector v1, Vector v2)
    {
        return Add(v1,v2);
    }
    public static Vector operator -(Vector v1, Vector v2)
    {
        return Subtract(v1,v2);
    }
    public static double operator *(Vector v1, Vector v2)
    {
        return Dot(v1,v2);
    }
    public static Vector operator *(Vector v1, double Scalar)
    {
        return Multiply(v1,Scalar);
    }
    public static Vector operator /(Vector v1, double Scalar)
    {
        return Divide(v1,Scalar);
    }
}