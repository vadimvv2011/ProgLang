// Вывести числа от 1 до N
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

string PrintRowRec(int number)
{
    if(number == 1) 
        return "1, ";
    else 
        return PrintRowRec(number - 1) + number + ", ";
}

int N = InputInt("Введите целое число: ");
Console.WriteLine($"Числа от 1 до {N}: {PrintRowRec(N)}");
