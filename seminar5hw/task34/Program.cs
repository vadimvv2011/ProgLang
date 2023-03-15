// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

void FillArray(int [] array ) 
{     
    for (int i =0; i<array.Length; i++)         
    array[i] = new Random().Next(100,1000); 
} 

void NumberEven(int [] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0) count++;
    }
    Console.WriteLine($"Количество чётных цифр равно {count}");
}


int [] array = new int [5];
FillArray(array);
PrintArray(array);
NumberEven(array);
