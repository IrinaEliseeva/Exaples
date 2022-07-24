//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = 5;
int b = 7;
Console.WriteLine("введите два числа");

string? sa = Console.ReadLine();
string? sb = Console.ReadLine();

int.TryParse(
    sa,
    System.Globalization.NumberStyles.Integer,
    null,
    out a
);

int.TryParse(
    sb,
    System.Globalization.NumberStyles.Integer,
    null,
    out b
);

Console.Write("максимальное число: ");

if (a > b)
{
    Console.Write(a);
}
else
{
    Console.Write(b);
}
