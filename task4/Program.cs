/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
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
        for (int i = 0; i < n; i++){
            if (i%2==0 && i>0){
                Console.Write(i);
                if (i<n-1) {
                    Console.Write(", ");
                }
            }            
        }
    }
}
