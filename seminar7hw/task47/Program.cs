// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int InputInt(string message) 
{   Console.Write(message);
    int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber; }

void Fill2DArrayByDouble(double [,] array)
{   for(int i = 0; i < array.GetLength(0); i++)
    {   for(int j = 0; j < array.GetLength(1); j++)
            // array[i,j] = Math.Round(new Random().NextDouble() * 10, 1); // только положительные
            // array[i,j] = Math.Round((new Random().NextDouble() - 0.5) * 10, 1); // от -5 до 5
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 101)) / 10; // от -10 до 10
    }
}

void Print2DArrayDouble(double [,] array)
{   for(int i = 0; i < array.GetLength(0); i++)
    {   for(int j = 0; j < array.GetLength(1); j++)
        {   Console.Write($"{array[i,j],4} \t");  }
        Console.Write("\n");
    }
}

int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");
double[,] array2d = new double[row,col];
Fill2DArrayByDouble(array2d);
Print2DArrayDouble(array2d);
