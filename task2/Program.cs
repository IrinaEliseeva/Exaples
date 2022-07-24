/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
public class io{
  public static int ReadInt() {
        string? sa = Console.ReadLine();
        int a;

        int.TryParse(
            sa,
            System.Globalization.NumberStyles.Integer,
            null,
            out a
        );

        return a;
    }
}

public class Program {
    static void Main() {
        Console.WriteLine("Введите число: ");
        int n = io.ReadInt();
        
        Console.WriteLine(n % 2==0? "чётное": "нечётное");
    }
}
