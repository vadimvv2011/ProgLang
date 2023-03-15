// Задача НЕГАФИБОНАЧЧИ. Задайте число. 
// Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

void PrintArr(int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

void NegaFibo(int[] arrFibo, int n)
{
    arrFibo [n - 1] = 0;
    if(n>1) 
    {
        arrFibo [n - 2] = 1;
        arrFibo [n] = 1;
        if(n>2)
        {
            for(int i = 2; i < n; i++)
            {
                arrFibo [n - 1 + i] = arrFibo[n - 1 + i - 1] + arrFibo[n - 1 + i - 2];
                arrFibo [n - 1 - i] = arrFibo[n - 1 - i + 2] - arrFibo[n - 1 - i + 1];
            }
        }
    }
}


Console.Write("Введите целое положительное число  ");
int N=Convert.ToInt32(Console.ReadLine());
int [] arrNegaFibo = new int [2*N-1];
NegaFibo(arrNegaFibo, N);
Console.Write($"Ряд негафибоначчи для числа {N} выглядит так: ");
PrintArr(arrNegaFibo);
