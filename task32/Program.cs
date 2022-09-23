// Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

int[] numbers = CreateArray(10);
PrintArray(numbers);
Replace(numbers);
PrintArray(numbers);

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

void Replace(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}



/*int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}

foreach (int number in array)
{
    Console.Write($"{number} ");
}*/