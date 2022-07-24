/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

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

public class ArrayHelper {
    public static int Max(int[] arr)
    {
        if (arr.Length == 0) {
            return 0;
        }

        int max = arr[0];
        foreach (int  a in arr) {
            if (a>max) {
                max = a;
            }
        }

        return max;
    }
}

public class Program {
    static void Main() {
        Console.WriteLine("Введите три числа: ");
        int[] arr = new int[3];
        for (int i = 0; i < 3; i++){
            arr[i] = io.ReadInt();
        }

        int max = ArrayHelper.Max(arr);
        Console.Write("максимальное число: ");
        Console.WriteLine(max);
    }
}
