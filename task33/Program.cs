// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

foreach (int element in array)
{
    Console.Write($"{element} ");
}
Console.WriteLine("");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

bool num = false;

for (int i = 0; i < array.Length; i++)
{
    if(number == array[i])
    {
        num = true;
    }
}

if(num)
{
    Console.WriteLine($"{number} есть в массиве");
}
else
{
    Console.WriteLine($"{number} нет в массиве");
}