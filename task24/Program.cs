Console.Write("Введите число N: ");
int max = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= max; i++)
    sum = sum + 1;
Console.WriteLine(sum);