// Задача 26: 
// Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе. 
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

// int a = Convert.ToInt32(Math.Log10(n));
// ---
// int Index(double num) { int count = 0; while ((num % 1) > 0) {      num = (num * 10);      Console.WriteLine(num); }  while (num > 1) { num = (num / 10);  count = count + 1;} return count; }  Console.WriteLine("Введите число"); double num = Convert.ToDouble(Console.ReadLine()); Console.WriteLine(Index(num));

