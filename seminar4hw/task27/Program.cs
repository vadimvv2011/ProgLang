// Задача 27: 
// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumNumbers(int n)
{
    // int[] arr = new int[1];
    int sum=0;
    for(int i=0; n!=0; i++)
    {
        // arr[i]=n%10;
        sum=sum+n%10;
        n=n/10;
        // if(n==0) break;
        // Array.Resize(ref arr, i+2);
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна {SumNumbers(number)}");
