// Задача 50. 
// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

void IsPresent (int [,] array, int el)
{
    int row = -1;
    int col = -1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(array[i,j] == el) 
            {
                row = i;
                col = j;
            }
        }
    }
    if(row != -1 && col != -1) Console.WriteLine($"элемент {el} находится в позиции [{row}, {col}]");
    else Console.WriteLine($"элемента {el} нет");
}

void Print2DArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.Write("\n");
    }
}


int [,] array2d = new int[,] {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
Console.Write("Введите целое число от 1 до 25: ");
int element=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("В массиве: ");
Print2DArray(array2d);
IsPresent (array2d, element);
