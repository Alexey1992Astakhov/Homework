//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.WriteLine("{0} - максимальное число, {1} - минимальное число", a, b);
else Console.WriteLine("{0} - максимальное число, {1} - минимальное число", b, a);
