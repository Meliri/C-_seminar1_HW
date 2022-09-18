Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Число является четным и делится на 2 без остатка");
}
else
{
    Console.WriteLine("Число не четное и не делится на 2 без остатка");
}
if(number % 2 == 0)
{
    Console.WriteLine(number / 2);
}