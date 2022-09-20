Console.WriteLine("Введите координаты первой точки X1 и Y1: ");
string x1y1 = Console.ReadLine();
string[] partsA = x1y1.Split (' ');
int x1 = int.Parse (partsA[0]);
int y1 = int.Parse (partsA[1]);
Console.WriteLine("Введите координаты второй точки X2 и Y2: ");
string x2y2 = Console.ReadLine();
string[] partsB = x2y2.Split(' ');
int x2 = int.Parse (partsB[0]);
int y2 = int.Parse (partsB[1]);

double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между X и Y = {length}");
