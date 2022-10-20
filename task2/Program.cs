double b1 = ReadInt("Задайте значение b1: ");
double k1 = ReadInt("Задайте значение k1: ");
double b2 = ReadInt("Задайте значение b2: ");
double k2 = ReadInt("Задайте значение k2: ");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = x * k1 + b1;
    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}




int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());       
}
