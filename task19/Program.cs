// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter five digit number: ");
string num = Console.ReadLine();
if (num.Length == 5)
{
    CheckingForPalindrome(num);
}
else Console.WriteLine($"Enter a correct number ");


void CheckingForPalindrome(string number)
{
    if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine($" Is the number {number} a palindrome? -> yes");
    else Console.WriteLine($"Is the number {number} a palindrome? -> no");
}
