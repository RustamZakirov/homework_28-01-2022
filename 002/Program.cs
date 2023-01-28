// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a < b) 
    max = b;
else
    max = a;
if (max < c)
    max = c;
Console.WriteLine($"максимальное число = {max}");