// Возведите в степень N число M

int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

int StepenRec(int number, int pow)
{
    if(pow == 1) 
        return number;
    else
        return StepenRec(number, pow - 1) * number;
}

int M = InputInt("Введите целое число: ");
int N = InputInt("Введите целую положительную степень: ");
Console.WriteLine($"Число {M} в степени {N} равно: {StepenRec(M, N)}");
