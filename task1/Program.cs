Console.Write("Введите число a = ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b = ");
int numberB = int.Parse(Console.ReadLine());
if (numberB * numberB == numberA) {
    Console.WriteLine("Число а квадрат числа b");
} else {
    Console.WriteLine("Число а не квадрат числа b");
}