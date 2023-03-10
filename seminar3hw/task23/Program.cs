// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите целое число");
int N=Convert.ToInt32(Console.ReadLine());
Kub(N);
void Kub(int N)
{
    for(int i=1;i<=N;i++)
    {
        if(i<N) Console.Write($"{i*i*i}, ");
        if(i==N) Console.WriteLine(i*i*i);
    }
}
