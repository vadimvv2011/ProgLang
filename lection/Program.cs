
// Console.WriteLine("Hello, World, twice!");

// int number1 = new Random().Next(1,100); // от 1 до 99
// int number2 = new Random().Next(1,100);
// Console.Write(number1+number2);

// Console.WriteLine("Введите Ваше имя");
// string name=Console.ReadLine();
// if(name=="Masha")
//     Console.Write("Привет, Маша");
// else
//     Console.Write("Привет");
Console.WriteLine("Введите первое число");
double number1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите второе число");
double number2=Convert.ToDouble(Console.ReadLine());

double number3 = Convert.ToDouble(new Random().Next(1,1000));
Console.Write("Третье число будет равно ");
Console.WriteLine(number3);

double number4=Convert.ToDouble(new Random().Next(1,1000));
Console.Write("Четвертое число это - ");
Console.WriteLine(number4);

Console.WriteLine("Введите пятое число");
double number5=Convert.ToDouble(Console.ReadLine());

double max=number1;
if(number2>max) max=number2;
if(number3>max) max=number3;
if(number4>max) max=number4;
if(number5>max) max=number5;

Console.Write("Maximum is ");
Console.WriteLine(max);
