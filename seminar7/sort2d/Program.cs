int InputInt(string message)
{
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber;
}

void Fill2DArrayByInt(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,20);
}

void Print2DArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],1} \t");
        Console.Write("\n");
    }
    Console.WriteLine("=================================");
}

void Sort2D(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int imin = i;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int jmin = j;
            for(int k = i; k < array.GetLength(0); k++)
            {
                if(k == i) 
                {
                    for(int l = j; l < array.GetLength(1); l++)
                    {
                    if(array[k, l] < array[imin, jmin])
                    {
                        imin = k;
                        jmin = l;
                    }
                    }
                } 
                else 
                {
                    for(int l = 0; l < array.GetLength(1); l++)
                    {
                    if(array[k, l] < array[imin, jmin])
                    {
                        imin = k;
                        jmin = l;
                    }
                    }
                }
            }
            if(imin != i || jmin != j)
            {int temp = array[i, j];
            array[i, j] = array[imin, jmin];
            array[imin, jmin] = temp;
            }
        }    
    }
}


int row = InputInt("Введите количество строк: ");
int col = InputInt("Введите количество столбцов: ");
int [,] array2d = new int [row, col];

Fill2DArrayByInt(array2d);
Print2DArray(array2d);

Sort2D(array2d);
Print2DArray(array2d);
