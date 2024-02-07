// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// *** Private Member Variables ***
// i magnitude (x)
// j magnitude (y)

// *** Public Member Variables ***
// Magnitude
// Direction

// *** Public Static Functions ***
// Vector addition
// Scalar multiplication
// Dot product

Vector2d vector2D = new Vector2d(4, 5);
Vector2d vector2DA = new Vector2d(5, -6);

Console.WriteLine($"{vector2D.i}, {vector2D.j}");

Console.WriteLine($"{vector2D.Magnitude}");

Console.WriteLine($"{vector2D.Direction}");

Console.WriteLine($"{Vector2d.DotProduct(vector2D, vector2DA)}");

Vector2d vec2DB = Vector2d.Add(vector2DA, vector2D);

Console.WriteLine($"{vec2DB.i}, {vec2DB.j}");

Vector2d vec2DC = Vector2d.Multiply(vector2D, 3);

Console.WriteLine($"{vec2DC.i}, {vec2DC.j}");