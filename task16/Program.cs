Console.Write("Введите число a = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b = ");
int numberB = int.Parse(Console.ReadLine());

if (numberA * numberA == numberB)
{
    Console.WriteLine("Число a квадрат от b");
}
if (numberB * numberB == numberA)
{
    Console.WriteLine("Число b квадрат от a");
}
else
{
    Console.WriteLine("а и b не являются квадратом друг друга");
}