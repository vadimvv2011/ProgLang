// int a1=1;
// int b1=2;
// int c1=3;
// int a2=11;
// int b2=21;
// int c2=31;
// int a3=11;
// int b3=12;
// int c3=131;

// int max=a1;

// if(b1>max) max=b1;
// if(c1>max) max=c1;

// if(a2>max) max=a2;
// if(b2>max) max=b2;
// if(c2>max) max=c2;

// if(a3>max) max=a3;
// if(b3>max) max=b3;
// if(c3>max) max=c3;

// Console.WriteLine(max);

// int a1=1;
// int b1=2;
// int c1=3;
// int a2=11;
// int b2=21;
// int c2=31;
// int a3=11;
// int b3=121;
// int c3=13;

// Console.WriteLine(Max(
//     Max(a1,b1,c1),
//     Max(a2,b2,c2),
//     Max(a3,b3,c3)));

int Max(int a, int b, int c)
{
    int max=a;
    if(b>max) max=b;
    if(c>max) max=c;
    return max;
}

int[] array = {1,2,3,4,5,6,7,8,9};
Console.WriteLine(Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])));
