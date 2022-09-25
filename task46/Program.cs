﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[ , ] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);



int EnterInt(string promt)
{
    Console.Write(promt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j], 3} ");
        }
        Console.WriteLine();
    }
}