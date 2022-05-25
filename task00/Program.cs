// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, 
                                                        // y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы

Console.Write("введите коэф. В1=");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("введите коэф. K1=");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("введите коэф. В2=");
double b2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("введите коэф. K2=");
double k2 = double.Parse(Console.ReadLine() ?? "0");
double x = ((b2-b1)/(k1-k2));
double y = ((k1*b2 - k2*b1)/(k1-k2));
Console.WriteLine($"Координаты точки пересеч.прямых М({x},{y})");