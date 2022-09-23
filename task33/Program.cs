// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
   /*  Console.Write($"{array[i]} "); */
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}
