// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int[] CreateArray (int size)
{
    int[] num = new int[size];

    for (int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(0,2);
    }
    return num;
}

void PrintArray (int[] array)
{
    Console.WriteLine($"[{string.Join (", ", array)}]");
}

PrintArray (CreateArray(8));