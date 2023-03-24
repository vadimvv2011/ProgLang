// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

void Fill2DArrayByInt(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,6); }

void Print2DArray(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],2} \t");
        Console.Write("\n"); 
    } 
    }

void MultiplMatrix(int [,] arrayA, int [,] arrayB, int [,] resultArray)
{
    for(int m = 0; m < arrayB.GetLength(1); m++)
    {
        for(int i = 0; i < arrayA.GetLength(0); i++)
        {
            for(int j = 0; j < arrayA.GetLength(1); j++)
            {
                int k = j;
                resultArray[i, m] += arrayA[i, j] * arrayB[k, m];
            }
        }
    }
}


int rowA = InputInt("Введите количество строк первой матрицы: ");
int colA = InputInt("Введите количество столбцов первой матрицы: ");
int rowB = colA;
int colB = InputInt("Введите количество столбцов второй матрицы: ");

int [,] array2dA = new int [rowA, colA];
Fill2DArrayByInt(array2dA);
Print2DArray(array2dA);
Console.WriteLine("--------------------------");
int [,] array2dB = new int [rowB, colB];
Fill2DArrayByInt(array2dB);
Print2DArray(array2dB);
Console.WriteLine("--------------------------");

int [,] resultArray = new int [rowA, colB];
MultiplMatrix(array2dA, array2dB, resultArray);
Print2DArray(resultArray);
