﻿using System;
// this is using struct because it's not intended to be modified 
public struct Vector3
{
    //floating-point numbers to represent the position of a point on 3d Dimension using Vector3
    public float X;
    public float Y;
    public float Z;
    //Constroctor has 3 parameters , no parameterless constroctors in structs
    public Vector3(float x, y, z)
    {
        X = x;
        Y = y;
        Z = Z;
    }
    //some usefull shortcuts inspired from previous experience
    // this returns a new vector 3
    public static Vector3 zero
    {
        get
        {
            return new Vector3(0, 0, 0);
        }
    }
    // this returns the identity value of Vector3(1 1 1)
    public static Vector3 one
    {
        get
        {
            return new Vector3(1, 1, 1);
        }
    }
}