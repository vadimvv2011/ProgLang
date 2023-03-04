
// Console.WriteLine("Введите целое число");
// int N=Convert.ToInt32(Console.ReadLine());
// Kvadraty(N);

// void Kvadraty(int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write(i*i+" ");
//     }
// }

Console.WriteLine("Введите целое число больше нуля");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Kvadraty(N));

string Kvadraty(int N)
{
    string res="";
    for (int i = 1; i <= N; i++)
    {
        string str=Convert.ToString(i*i);
//        return str+" ";
        res=res+str+" ";
    }
    return res;
}
// 
