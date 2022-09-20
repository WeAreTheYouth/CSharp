Console.Write("Введите число a = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b = ");
int numberB = int.Parse(Console.ReadLine());
if (numberA % numberB == 0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine($"Числа не кратны, остаток {numberA % numberB}");
}