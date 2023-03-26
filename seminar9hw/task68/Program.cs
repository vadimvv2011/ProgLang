// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

int Ack(int m, int n)
{
    if(m == 0) 
        return n + 1;
    else if(n == 0) 
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}

int M = InputInt("Введите целое неотрицательное число: ");
int N = InputInt("Введите целое неотрицательное число: ");
Console.WriteLine($"Значение функции Аккермана равно: {Ack(M, N)}");
