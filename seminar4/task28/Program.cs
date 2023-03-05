
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел 
// от 1 до N. 4 -> 24  5 -> 120

Console.WriteLine("Введите целое число");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proizvedenie(N));

int Proizvedenie(int arg)
{
    int res=1;
    for(int i=1;i<=arg; i++)
    {
        res=res*i;
    }
    return res;
}
