int InputInt(string message)
{
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber;
}

void Fill2DArrayBySum(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++)
            array[i,j] = i + j;
}

void Print2DArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],1} \t");
        Console.Write("\n");
    }
}


int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");

int [,] array2d = new int [row,col];

Fill2DArrayBySum(array2d);
Print2DArray(array2d);
