﻿// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21

// Не решена

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


int [] array  = new int [12]; 
FillArray(array);
PrintArray(array);
