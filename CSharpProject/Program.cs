using System;

class Program {
    static void Main() {
        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сума: {a + b}");
    }
}
