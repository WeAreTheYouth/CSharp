// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array = CreateArray(11);
PrintArray(array);


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
        Console.Write($"[{String.Join(", ", array)}] ");
        Console.WriteLine("");
}


int[] newArray = new int[(array.Length + 1) / 2];
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    int j = array.Length - 1 - i;
    newArray[i] = array[i] * array[j];
}

Console.Write($"[{String.Join(", ", newArray)}] ");