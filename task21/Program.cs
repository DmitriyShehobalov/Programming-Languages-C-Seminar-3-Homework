// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter coordinates first point: ");
int coordinateFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates first point: ");
int coordinateSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates first point: ");
int coordinateThird = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates second point: ");
int coordinateFirst1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates second point: ");
int coordinateSecond1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates second point: ");
int coordinateThird1 = Convert.ToInt32(Console.ReadLine());

double DistancePoints(double a, double b, double c, double d, double e, double f)
{
    double firstpoint = d - a;
    double secondpoint = e - b;
    double thirdpoint = f - c;
    double distance = Math.Sqrt(firstpoint * firstpoint + secondpoint * secondpoint + thirdpoint * thirdpoint);
    return distance;
}
double result = DistancePoints(coordinateFirst, coordinateSecond, coordinateThird, coordinateFirst1, coordinateSecond1, coordinateThird1);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);