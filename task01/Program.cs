// Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.WriteLine("введите координаты 1 вершины");
int x1 = int.Parse(Console.ReadLine() ?? "0");
int y1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("введите координаты 2 вершины");
int x2 = int.Parse(Console.ReadLine() ?? "0");
int y2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("введите координаты 3 вершины");
int x3 = int.Parse(Console.ReadLine() ?? "0");
int y3 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("введите координаты 4 вершины");
int x4 = int.Parse(Console.ReadLine() ?? "0");
int y4 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("введите коэффициент масштабирования");
int k = int.Parse(Console.ReadLine() ?? "0");

int x1k = x1*k;
int y1k = y1*k;
int x2k = x2*k;
int y2k = y2*k;
int x3k = x3*k;
int y3k = y3*k;
int x4k = x4*k;
int y4k = y4*k;
Console.WriteLine("Заданные координаты:");
Console.WriteLine($"1 вершина ({x1},{y1}), 2 вершина ({x2},{y2}), 3 вершина ({x3},{y3}), 4 вершина ({x4},{y4})");
Console.WriteLine("Новые координаты:");
Console.WriteLine($"1 вершина ({x1k},{y1k}), 2 вершина ({x2k},{y2k}), 3 вершина ({x3k},{y3k}), 4 вершина ({x4k},{y4k})");
