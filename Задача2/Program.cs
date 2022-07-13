// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int Namber = Convert.ToInt32(Console.ReadLine());
string NamberText = Convert.ToString(Namber);
if(NamberText.Length > 2)
{
    Console.WriteLine("Третье цифра" + NamberText[2]);
}
else
//Console.WriteLine("Третье число " + a[2]);
Console.WriteLine("Третьей цыфры нет");    
    
    


