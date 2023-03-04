
Console.WriteLine("Введите целую координату Х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую координату Х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую координату Y первой точки");
int y2 = Convert.ToInt32(Console.ReadLine());

NomerChetverty(x1, y1, x2, y2);

void NomerChetverty(int x1, int y1, int x2, int y2)
{
    double dist=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    Console.WriteLine(dist);
}
