// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArr(int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}


int [] array = {1,2,5,7,19};
PrintArr(array);
int [] array1 = {6,1,33};
PrintArr(array1);
int [] array2 = {66,1,4,2,54,5,7,19};
PrintArr(array2);
