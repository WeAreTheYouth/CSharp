// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

/* const int Size = 12;

int[] numbers = new int[Size];

for (int i = 0; i < Size; i++)
{
    numbers[i] = new Random().Next(-9, 10);
}

int negativeSum = 0;
// для каждого числа number из массива чисел numbers
foreach (int number in numbers)
{
    if (number < 0)
        negativeSum += number;
}

int positiveSum = 0;
foreach (int number in numbers)
{
    if (number > 0)
        positiveSum += number;
}

Console.WriteLine($"Сумма положительных = {positiveSum}, сумма отрицательных = {negativeSum}"); */



const int Size = 12;
int[] numbers = CreateRandomArray(Size);
int positiveSum = CalcPositivesSum(numbers);
int negativeSum = CalcNegativesSum(numbers);
Console.WriteLine($"Сумма положительных = {positiveSum}, сумма отрицательных = {negativeSum}");

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-9, 10);
    }
    return numbers;
}

int CalcPositivesSum(int[] numbers)
{
    int positiveSum = 0;
    foreach (int number in numbers)
    {
        if (number > 0)
            positiveSum += number;
    }
    return positiveSum;
}

int CalcNegativesSum(int[] numbers)
{
    int negativeSum = 0;
    // для каждого числа number из массива чисел numbers
    foreach (int number in numbers)
    {
        if (number < 0)
            negativeSum += number;
    }
    return negativeSum;
}