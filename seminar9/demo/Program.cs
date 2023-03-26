// Посчитать сумму чисел от 1 до n
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

int SummaRec(int number)
{
    if(number == 1) 
        return 1;
    else 
        return number + SummaRec(number - 1);
}

int n = InputInt("Введите целое число: ");
Console.WriteLine($"Сумма чисел от 1 до {n} равна {SummaRec(n)}");
