// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число N ");
int num = int.Parse(Console.ReadLine());

int FindFactorial()
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.WriteLine($"{FindFactorial()}");
