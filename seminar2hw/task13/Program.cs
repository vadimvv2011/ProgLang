// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetIntNumber(string message)
{
    Console.Write(message);
    int IntNumber=Convert.ToInt32(Console.ReadLine());
    return IntNumber;
}

void ThirdDigit(int number)
{
    int temp=number;
    int counter=0;
    while(temp>0)
    {
        temp=temp/10;
        counter++;
    }
    if(counter<3) Console.Write("Третьей цифры нет.");
    else 
    {
        int i=counter-3;
        while(i!=0)
        {
            number=number/10;
            i--;
        }
        number=number%10;
        Console.Write("Третья цифра равна ");
        Console.WriteLine(number);
    }
}


int number=GetIntNumber("Введите целое число: ");
ThirdDigit(number);

