// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 

int[] array = CreateArray(123);
PrintArray(array);
Console.WriteLine($"{GetSum(array)} чисел в отрезке от 10 до 99");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int GetSum(int[] array)
{
    int sum = 0;
    foreach (int element in array)
    {
        if (element > 10 && element < 100)
        {
            sum++;
        }
    }
    return sum;
}
