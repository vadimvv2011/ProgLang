// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArrayString(string [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

void PrintArrayInt(int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

void StringToInt(string [] arrayIn, int [] arrayOut)
{
    for(int i=0; i<arrayIn.Length; i++)
    {
        arrayOut[i]=Convert.ToInt32(arrayIn[i]);
    }
}

int NumMoreZero(int [] array)
{
    int count=0;
    foreach(int element in array)
    {
        if(element>0) count++;
    }
    return count;
}

// string myString="0, 7, 8, -2, -2";
Console.Write("Введите целые числа через запятую: ");
string myString=Console.ReadLine();
myString=myString.Replace(" ","");
// Console.WriteLine(myString);
string[] subStrings = myString.Split(',');
// PrintArrayString(subStrings);
int [] numArray = new int [subStrings.Length];
StringToInt(subStrings, numArray);
// PrintArrayInt(numArray);
Console.WriteLine($"Количество чисел больше нуля равно {NumMoreZero(numArray)}");
// Console.WriteLine($"Из чисел {myString} количество элементов больше нуля равно {NumMoreZero(numArray)}");
