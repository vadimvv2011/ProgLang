// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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

void SummEven(int [] array)
{
    int summ=0;
    for(int i=0; i<array.Length; i++)
    {
        if(i%2==1) summ+=array[i];
    }
    Console.WriteLine($"Сумма нечётных элементов равна {summ}");
}


int [] array = new int [5];
FillArray(array);
Console.Write("В массиве");
PrintArray(array);
SummEven(array);
