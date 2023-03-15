// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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
    array[i] = new Random().Next(10,100); 
}

void Raznost(int [] array)
{
    int min=array[0];
    int max=array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(array[i]>max) max=array[i];
        if(array[i]<min) min=array[i];
    }
    int raznost=max-min;
    Console.WriteLine($"Разность максимального и минимального элементов равна {raznost}");
}


int [] array = new int [5];
FillArray(array);
Console.Write("В массиве");
PrintArray(array);
Raznost(array);
