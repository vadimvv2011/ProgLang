// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число: ");
int number=Convert.ToInt32(Console.ReadLine());
Pal(number);

void Pal(int number)
{
    int a5=number%10;
    number=number/10;
    int a4=number%10;
    number=number/10;
    int a3=number%10;
    number=number/10;
    int a2=number%10;
    number=number/10;
    int a1=number%10;
    
    if(a1==a5)
    {
        if(a2==a4) Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}   

// return result;
// Console.WriteLine($"пятое число {a1},{a2},{a3},{a4},{a5}");
// int number=12;
// int a1=number/10;
// int a2=number%10;
// Console.WriteLine(Convert.ToString(a1));
// Console.WriteLine(Convert.ToString(a2));
