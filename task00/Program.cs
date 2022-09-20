Console.WriteLine("Введите число");
string input = Console.ReadLine(); // ввод
int number = int.Parse(input); // перевод в число
int square = number * number; // квадрат
Console.WriteLine($"Число в квадрате равно {square}");