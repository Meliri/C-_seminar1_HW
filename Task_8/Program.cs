﻿Console.WriteLine("Введите Любое целое число:");
int user_number = int.Parse(Console.ReadLine());
int x = 0;

Console.WriteLine("Все четные числа от 1 до " + user_number + ":");
while (x < user_number)
{
    Console.WriteLine(x += 2);
}