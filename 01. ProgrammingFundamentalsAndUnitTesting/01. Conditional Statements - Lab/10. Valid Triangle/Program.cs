int side1 = int.Parse(Console.ReadLine());
int side2 = int.Parse(Console.ReadLine());
int side3 = int.Parse(Console.ReadLine());

bool isValidTriangle = IsTriangleValid(side1, side2, side3);

if (isValidTriangle)
{
    Console.WriteLine("Valid Triangle");
}

else
{
    Console.WriteLine("Invalid Triangle");
}

    static bool IsTriangleValid(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (b + c > a);
}