int AmountNumbers(int num)
{
    int numbers = 0;
    while (num > 0)
    {
        num = num / 10;
        numbers = numbers + 1;
    }
    return numbers;
}

Console.WriteLine("Введите число N");
int num = 0;
num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел в {num} {AmountNumbers(num)}");