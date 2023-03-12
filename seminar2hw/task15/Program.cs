// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int GetIntNumber(string message)
{
    Console.Write(message);
    int IntNumber=Convert.ToInt32(Console.ReadLine());
    return IntNumber;
}

void Holliday(int number)
{
    if(number<1 || number>7) Console.WriteLine("Введено некорректное число");
    else if(number>=1 && number <=5) Console.WriteLine("Нет");
    else Console.WriteLine("Да");
}

int number=GetIntNumber("Введите число от одного до восьми ");
Holliday(number);
