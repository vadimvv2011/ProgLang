// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
// Тогда на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Print2DArray(int [,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],2} \t");
        Console.Write("\n"); 
    } 
}

int [,] matrix = new int[4, 4];

int count = 1;
int i = 0;
int j = 0;
while(count <= 12)
// while(count <= matrix.GetLength(0) * matrix.GetLength(1))
{
    if(matrix[i, j] == 0) 
    {
        matrix[i, j] = count;
        count++;
    }
    else
    {
        if(j < matrix.GetLength(1)-1){
            if(matrix[i, j + 1] == 0) { 
                if(i = 0) j++;
                // else if (matrix[i-1, j] == 0) }
            else 
                if (j > 0) j--; 
                else 
                    if (i > 0) 
                        if(matrix[i-1,j] == 0) { i--; }}
        else 
            if (i < matrix.GetLength(0)-1) 
            { i++; }
            else
                if (j > 0) j--;
                else 
                    if (i > 0) 
                        if(matrix[i-1,j] == 0) { i--; }
        // else if (j > 0) j--;
        // else if (i > 0) i--;
    }
}



Print2DArray(matrix);
