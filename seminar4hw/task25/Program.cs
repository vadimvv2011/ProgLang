// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Degree(int number, int degree)
{
    if(degree==1) 
        {
            Console.WriteLine($"Число {number} в степени {degree} равно {number}");
            return;
        }
    int result=number;
    for(int i=2; i<=degree;i++)
    {
        result=result*number;
    }
    Console.WriteLine($"Число {number} в степени {degree} равно {result}");
}


Console.Write("Введите целое число для возведения в степень: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную (целое число больше нуля) степень: ");
int degree=Convert.ToInt32(Console.ReadLine());
Degree(number, degree);
