//  Напишите программу, которая принимает на вход цифру, обозначающую день
//недели,и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num < 6) Console.WriteLine("Не выходной");
else
{
    //if (num == 1) Console.WriteLine("Понедельник");
    //if (num == 2) Console.WriteLine("Вторник");
    //if (num == 3) Console.WriteLine("Среда");
    //if (num == 4) Console.WriteLine("Четверг");
    //if (num == 5) Console.WriteLine("Пятница");
    if (num == 6) Console.WriteLine("Суббота");
    if (num == 7) Console.WriteLine("Воскресенье");
    if (num > 7) Console.WriteLine("Нет такого дня недели");
}
