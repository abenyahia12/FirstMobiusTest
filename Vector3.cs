using System;
// this is using struct because it's not intended to be modified 
public struct Vector3
{
    //Variables
    //floating-point numbers to represent the position of a point on 3d Dimension using Vector3
    public float X;
    public float Y;
    public float Z;
    //Constroctor has 3 parameters , no parameterless constroctors in structs
    public Vector3(float x, y, z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    //some usefull shortcuts inspired from previous experience
    // this returns a new vector 3
    public static Vector3 Zero
    {
        get
        {
            return new Vector3(0, 0, 0);
        }
    }
    // this returns the identity value of Vector3(1,1,1)
    public static Vector3 One
    {
        get
        {
            return new Vector3(1, 1, 1);
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////
    //Methods Static
    // "+" operator 
    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }
    // "-" operator
    public static Vector3 operator +(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }
    // "*" operator
    public static Vector3 operator *(Vector3 a, float multiplier)
    {
        return new Vector3(multiplier * a.X, multiplier * a.Y, multiplier * a.Z);
    }
    // "/" operator
    public static Vector3 operator /(Vector3 a, float divider)
    {
        return new Vector3(a.X / divider, a.Y / divider, a.Z / divider);
    }
    // this gives us the Vector3 that is perpendicular to the plan made by a and b
    // I used this link to remember the math behind cross function https://www.cuemath.com/geometry/cross-product/
    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        float x, y, z;
        x = a.Y * b.Z - b.Y * a.Z;
        y = (a.X * b.Z - b.X * a.Z) * -1;
        z = a.X * b.Y - b.X * a.Y;
        return new Vector3(x,y,z);
    }
    // a simple multiplication of each vector's coordinate with the corespondant one on the other
    public static Vector3 Dot(Vector3 a, Vector3 b)
    {
        return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }
    /// ///////////////////////////////////////////////////////
    // Non Static Methods
    //   ||V||=sqrt(x²+y²+z²) this returns the magnitude of a vector a.
    public float GetMagnitude(Vector3 a)
    {
        return Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2) + Math.Pow(a.Z, 2));
    }
    //     normal = a/ ||a|| which translates to a divided by magnitude function.
    public Vector3 GetNormalized(Vector3 a)
    {
        return a / GetMagnitude(a);
    }
}