// Вывести числа от M до N
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

string PrintRowRec(int numberMin, int numberMax)
{
    if(numberMax == numberMin) 
        return numberMin + ", ";
    else 
        return PrintRowRec(numberMin, numberMax - 1) + numberMax + ", ";
}

int M = InputInt("Введите целое число: ");
int N = InputInt("Введите целое число, которое больше предыдущего: ");

Console.WriteLine($"Числа от {M} до {N}: {PrintRowRec(M, N)}");
