// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void RowSum(int [,] array2d, int [] array) 
{
    for(int i = 0; i < array2d.GetLength(0); i++)
        for(int j = 0; j < array2d.GetLength(1); j++)
            array[i] += array2d[i,j];
}

void NumMin(int [] array)
{
    int min = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < array[min]) min = i;
    }
    Console.WriteLine($"C наименьшей суммой элементов: {min + 1} строка");
}


int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");
int [,] array2d = new int [row, col];
int [] resultArray = new int [row];

Fill2DArrayByInt(array2d);
Print2DArray(array2d);
RowSum(array2d, resultArray);
NumMin(resultArray);
