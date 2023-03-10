// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите целое значение координаты Х первой точки: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое значение координаты Y первой точки: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое значение координаты Z первой точки: ");
int z1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое значение координаты Х второй точки: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое значение координаты Y второй точки: ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое значение координаты Z второй точки: ");
int z2=Convert.ToInt32(Console.ReadLine());

Distance(x1,y1,z1,x2,y2,z2);

void Distance(int x1,int y1,int z1,int x2,int y2,int z2)
{
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2)),2));
}
