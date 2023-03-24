// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

void Fill2DArrayByInt(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,20); }

void Print2DArray(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],1} \t");
        Console.Write("\n"); 
    }
    Console.WriteLine("================================="); }

void SortRow(int [,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int k = i;
                    for(int l = j; l < array.GetLength(1); l++)
                    {
                    if(array[k, l] > array[i, j])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[k, l];
                        array[k, l] = temp;
                    }
                    }
        }    
    }
}


int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");
int [,] array2d = new int [row, col];

Fill2DArrayByInt(array2d);
Print2DArray(array2d);

SortRow(array2d);
Print2DArray(array2d);
