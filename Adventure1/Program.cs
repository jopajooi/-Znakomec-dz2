// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
System.Console.WriteLine("Enter number   ");
int a = Convert.ToInt32(Console.ReadLine()); ;
int b = (a % 100 - a % 10) / 10;
if (a < 10)
{
    System.Console.WriteLine("Это не трёхзначное число");
}
if (a > 1000)
{
    System.Console.WriteLine("Это не трёхзначное число");

}
else

    System.Console.WriteLine($"Это цифра {b}");

