﻿int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int digit1 = number / 100;
int digit3 = number % 10;

Console.WriteLine($"{digit1}{digit3}");