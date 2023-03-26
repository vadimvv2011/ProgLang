// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

string PrintNegaDigitsRec(int number)
{
    if(number == 1) 
        return "1";
    else
        return  number + ", " + PrintNegaDigitsRec(number - 1);
}

int N = InputInt("Введите целое число: ");
Console.WriteLine($"Цифры от {N} до 1: {PrintNegaDigitsRec(N)}");
