// See https://aka.ms/new-console-template for more information



Console.WriteLine("Введите номер чеверти");
int number = Convert.ToInt32(Console.ReadLine());
NomerChetverty(number);

void NomerChetverty(int number)
{
if(number==1)
    Console.WriteLine("x>0, y>0");
else if (number==2)
    Console.WriteLine("x<0, y>0");
else if (number==3)
    Console.WriteLine("x<0, y<0");
else if (number==4)
    Console.WriteLine("x>0, y<0");
else
    Console.WriteLine("Введено неверное значение");
}