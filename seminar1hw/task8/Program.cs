Console.WriteLine("Input one number");
int N=Convert.ToInt32(Console.ReadLine());
int count=1;
while (count<=N)
{
    if(count%2==0) 
    {
        Console.Write(count);
        // if(count!=N || count!=N-1) Console.Write(", ");
        if(count!=N)
        {
            if(count!=N-1) Console.Write(", ");
        }
    }
    count++;
}
