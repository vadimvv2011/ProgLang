// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и 
// проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine("Введите целое число: ");
double number=Convert.ToDouble(Console.ReadLine());

Pal(number);

void Pal(double number)
{
    double N=Math.Log10(number);
    // int N=Convert.ToInt32(Math.Log10(number));
    Console.WriteLine(N);
    // int[] arr=new int[N];
    // PrintArray(arr);
        // for(int i=N; i>=0; i--)
        // {
        //     arr[i-1]=number%10;
        //     number=number/10;
        // }
    
    // PrintArray(arr);
    
    // if(a1==a5)
    // {
    //     if(a2==a4) Console.WriteLine("Да");
    // }
    // else 
    // {
    //     Console.WriteLine("Нет");
    // }
}   
void PrintArray(int[] arr)
{
   for(int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+", ");
    } 
}