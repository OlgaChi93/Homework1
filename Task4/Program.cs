// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());


if (a>b && b>c || a>c && c>b)
{
    Console.WriteLine($"max = {a}" );
}
else if (c>b && b>a || c>a && a>b)
{
    Console.WriteLine($"max = {c}" );
}
else
{
    Console.WriteLine($"max = {b}" );
}


