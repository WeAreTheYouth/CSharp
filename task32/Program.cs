// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

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

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}
