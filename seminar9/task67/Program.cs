// Посчитайте сумму цифр в числе

int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

int SumDigitsRec(int number)
{
    if(number == 0) 
        return 0;
    else
        return SumDigitsRec(number / 10) + number % 10;
}

int N = InputInt("Введите многозначное целое число: ");
Console.WriteLine($"Сумма цифр в числе {N}: {SumDigitsRec(N)}");
