// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter n:");
var n = int.Parse(Console.ReadLine());

Console.WriteLine("a = " + A(n));
Console.WriteLine("b = " + B(n));
Console.WriteLine("c = " + C(n));

double A(int num)
{
    double sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += Math.Pow(-1, i) / (2*i + 1);
    }

    return sum;
}

double B(int num)
{
    double sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += 1 + 1 / Math.Pow(i, 2);
    }

    return sum;
}

int C(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        int fact = 1;
        for (int j = i; j > 1; j--)
        {
            fact *= j;
        }
        sum += fact;
    }

    return sum;
}