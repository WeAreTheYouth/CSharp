Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Диапозон x > 0, y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Диапозон x < 0, y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Диапозон x < 0, y < 0");
}
else if (number == 4)
{
    Console.WriteLine("Диапозон x > 0, y < 0");
}
else
{
    Console.WriteLine("такой четверти не существует");
}
