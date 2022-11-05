// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

void TableOfTheSquares(int sqr)
{
    for (int i = 1; i <= sqr; i++)
    {
        Console.WriteLine($"{i,3} {Math.Pow((i), 3),3}");
    }
}
TableOfTheSquares(num);