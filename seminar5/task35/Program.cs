// Задача 35: 
// Задайте одномерный массив из 12 случайных чисел от -100 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5

void FillArray(int [] array ) 
{     
    for (int i =0; i<array.Length; i++)         
    array[i] = new Random().Next(-100,101); 
}  
void PrintArray(int [] array) 
{     
    foreach (int el in array)     
    {         
        Console.Write($"{el} ");     
    }     
    Console.WriteLine(); 
} 
int Count(int [] array)
{
    int count=0;
    foreach(int el in array)
    {
        if(el>=10 && el<100) count++ ;          
        
    }
    return count;
}

int [] array  = new int [12]; 
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество цифр от 10 до 99 {Count(array)}"); 

