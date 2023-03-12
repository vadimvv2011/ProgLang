// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetIntNumber(string message)
{
    Console.Write(message);
    int IntNumber=Convert.ToInt32(Console.ReadLine());
    return IntNumber;
}

void SecondDigit(int number)
{
    number=number/10;
    number=number%10;
    Console.Write("Второе число равно ");
    Console.WriteLine(number);
}

int number=GetIntNumber("Введите трехзначное число: ");
SecondDigit(number);
