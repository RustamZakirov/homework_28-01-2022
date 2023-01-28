// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
    Console.WriteLine($"числа одинаковы и равны {a}");
else if (a > b)
    Console.WriteLine($"максимальное второе число = {a}");
else
    Console.WriteLine($"максимальное первое число = {b}");