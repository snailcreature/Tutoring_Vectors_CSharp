using System;
using System.Numerics;

class Vector2d
{
    public int i { get; set; }
    public int j { get; set; }

    public double Magnitude {
        get { return Math.Sqrt((double)(i*i + j*j)); }
    }

    public double Direction {
        get { return Math.Atan(j/i); }
    }

    public Vector2d(int i, int j)
    {
        this.i = i;
        this.j = j;
    }

    public static Vector2d Add(Vector2d A, Vector2d B)
    {
        return new Vector2d(A.i + B.i, A.j + B.j);
    }

    public static Vector2d Multiply(Vector2d A, int scalar)
    {
        return new Vector2d(A.i * scalar, A.j * scalar);
    }

    public static int DotProduct(Vector2d A, Vector2d B)
    {
        return A.i*B.i + A.j*B.j;
    }
}