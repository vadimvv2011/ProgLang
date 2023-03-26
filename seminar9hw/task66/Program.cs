// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
//     в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

int SummBetweenRec(int numberMin, int numberMax)
{
    if(numberMax == numberMin) 
        return numberMin;
    else
        return SummBetweenRec(numberMin, numberMax - 1) + numberMax;
}

int M = InputInt("Введите целое число: ");
int N = InputInt("Введите целое число, больше предыдущего: ");
Console.WriteLine($"Сумма натуральных элементов между [{M} и {N}] равно: {SummBetweenRec(M, N)}");
