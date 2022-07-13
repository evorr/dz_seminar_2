// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int secDigit = (num%100)/10;
Console.WriteLine($"{num} -> {secDigit}");
