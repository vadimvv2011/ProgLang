// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

void Fill2DArrayByInt(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,10); }

void Print2DArray(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],2} \t");
        Console.Write("\n"); 
    } 
    }

void PrintArray(double [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}");
    }
}

void ColumnAverage(int [,] array2d, double [] array) 
{
    for(int j = 0; j < array2d.GetLength(1); j++)
    {
        for(int i = 0; i < array2d.GetLength(0); i++)
        {
            array[j] += array2d[i,j];              
        }
        array[j] = Math.Round(array[j] / array2d.GetLength(0), 1);
    }
}


int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");
int [,] array2d = new int [row, col];
double [] resultArray = new double [col];

Fill2DArrayByInt(array2d);
Print2DArray(array2d);
ColumnAverage(array2d, resultArray);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(resultArray);
