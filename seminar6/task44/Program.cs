// Задача 44: 
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи:  0 и 1. 
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8
//============== Example!!!
// Console.WriteLine("Введите число N"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
 
// int [] array = new int[N]; 
 
// void FillArray(int [] array )   
// {       
//     array[0] = 0; 
//     array[1] = 1; 
//     for (int i =2; i<N; i++)     
//         array[i] = array[i-1] + array[i-2]; 
     
// }    
// FillArray(array); 
 
// foreach (int i in array) 
// { 
//     Console.Write(" "+i); 
// } 
//============
void PrintArr(int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

void Fibo(int[] arrFibo, int N)
{
    for(int i=1; i<=N; i++)
    {
        if(i==1) arrFibo[i-1]=0;
        else if(i==2) arrFibo[i-1]=1;
        else arrFibo[i-1]=arrFibo[i-2]+arrFibo[i-3];
    }
}

// Console.Write("Введите целое положительное число  ");
// int N=Convert.ToInt32(Console.ReadLine());
// int [] arrFibo = new int [N];
// Fibo(arrFibo, N);
// PrintArr(arrFibo);
//-------------------------------------------------------
// Задача НЕГАФИБОНАЧЧИ. 
// Задайте число. Составьте список чисел НегаФибоначчи, 
// в том числе для отрицательных индексов. 
// *Пример:* - для k = 9 список будет выглядеть так: 
// [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
