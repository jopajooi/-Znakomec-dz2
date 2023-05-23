// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123


Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 10)
{
    System.Console.WriteLine("нет");
    return;
}
int a = (int)Math.Log10(number) + 1;
int b = (int)Math.Pow(10, a - 2);
int result = number % b + number / b / 10 * b;

Console.WriteLine(result);
