// Задача 1
int a = 5;
int b = 7;
int max = a;
int min = b;
if (a > b) 
{
    max = a; min = b;
}
else
{
    max = b; min = a;
}
Console.Write ("max =  ");
Console.WriteLine (max);
Console.Write ("min =  ");
Console.WriteLine (min);