// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int [] array )  
{      
    for (int i =0; i<array.Length; i++)          
    array[i] = new Random().Next(-100,101);  
}   

void PrintArray(int [] array)  
{      
    foreach (int el in array)      
    {          
        Console.Write($"{el} ");      
    }      
    Console.WriteLine();  
}

void ChangeArray(int [] array)
{
   // int temp;
    for (int i =0; i<array.Length/2; i++)  
    {
        // temp = array[i];
        // array[i] = array[array.Length-1-i];
        // array[array.Length-1-i] = temp;
        (array[i] , array[array.Length-1-i]) = (array[array.Length-1-i], array[i]);
    }
}


int [] array = new int [7];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArray(array);
