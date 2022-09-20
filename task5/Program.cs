Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
for ( int i = -number; i <= number; i++) {
    Console.WriteLine($"{i}");
}