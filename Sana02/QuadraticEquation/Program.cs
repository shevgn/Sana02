// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a:");
var a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
var b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter c:");
var c = int.Parse(Console.ReadLine());

float D = b*b - 4*a*c;
Console.WriteLine("D is " + D);

var x1 = (-b + float.Sqrt(D)) / 2*a;
var x2 = (-b - float.Sqrt(D)) / 2*a;

if (D > 0)
{
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
} 
else if (D == 0)
{
    Console.WriteLine("x = ", x1);
}
else
{
    Console.WriteLine("No x's found");
}