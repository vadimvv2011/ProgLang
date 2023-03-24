// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int InputInt(string message) {
    Console.Write(message);
    int intNumber=Convert.ToInt32(Console.ReadLine());
    return intNumber; }

void Fill3DArrayByUniqInt(int [,,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                while(array[i, j, k] == 0)
                {
                    bool flag = false;
                    int popytka = new Random().Next(10, 100);
                    foreach(int element in array)
                    {
                        if(popytka == element) flag = true;
                    }
                    if(flag) array[i, j, k] = 0;
                    else array[i, j, k] = popytka;
                }
}

void Print3DArray(int [,,] array) {
    for(int k = 0; k<array.GetLength(2); k++)
        for(int i = 0; i < array.GetLength(0); i++) {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i,j,k],2}({i},{j},{k}) \t");
            Console.Write("\n"); 
        } 
    }

int dimension1 = InputInt("Введите первую размерность массива (кол-во строк): ");
int dimension2 = InputInt("Введите вторую размерность массива (кол-во столбцов): ");
int dimension3 = InputInt("Введите третью размерность массива (кол-во ...): ");
int [,,] array3d = new int[dimension1, dimension2, dimension3];
Fill3DArrayByUniqInt(array3d);
Print3DArray(array3d);
