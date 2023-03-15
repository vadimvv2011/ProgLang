// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputDouble(string message)
{
    Console.Write(message);
    double doubleNumber=Convert.ToDouble(Console.ReadLine());
    return doubleNumber;
}

void TochkaPer(double b1, double k1, double b2, double k2)
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    Console.Write($"точка пересечения имеет координаты ({x}; ");
    Console.WriteLine($"{y})");
}

double b1=InputDouble("Введите b1 ");
double k1=InputDouble("Введите k1 ");
double b2=InputDouble("Введите b2 ");
double k2=InputDouble("Введите k2 ");

TochkaPer(b1, k1, b2, k2);

// Console.Write("Введите k1 ");
// double k1=Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите b1 ");
// double b1=Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите k2 ");
// double k2=Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите b2 ");
// double b2=Convert.ToDouble(Console.ReadLine());

