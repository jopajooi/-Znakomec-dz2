// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Clear();
System.Console.WriteLine("Enter number   ");
int a = Convert.ToInt32(Console.ReadLine());
int result = -1;
if (a >= 100)
{
    while (a > 999)
    {
        a = a / 10;
    }
    result = a % 10;

}

if (a < 100)
{
    System.Console.WriteLine("Третей цифры не существует");
}
else
{
    System.Console.WriteLine($"Это цифра {result}");
}
