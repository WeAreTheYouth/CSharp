Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
double[] array = new double[number];
for (int i = 1; i <= number; i++)
{
    array[i - 1] = i * i;
    Console.Write($"{array[i - 1]} ");
}

