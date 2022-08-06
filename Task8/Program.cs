// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int min = 0;
int counter=1;

while  (min <= (N-2))
{
    min=min+2;
    Console.Write (min + " ");
    counter++;
}