// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число");
int nam = int.Parse(Console.ReadLine());
int nam1 = (nam / 10) % 10;
Console.WriteLine(nam1);
