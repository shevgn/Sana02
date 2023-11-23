// See https://aka.ms/new-console-template for more information

var sum = 0;
var count = 0;
for (var i = 0; i < 5; i++)
{
    Console.WriteLine("Enter student mark (from 0 to 100): ");
    int mark = int.Parse(Console.ReadLine());
    if (mark <= 100 && mark >= 0)
    {
        sum += mark;
        count++;
    }
    else
    {
        Console.WriteLine("Wrong input!");
    }
}

if (count != 0)
{
    var average = sum / count;
    Console.WriteLine("Average is " + average);
    if (average >= 50)
    {
        Console.WriteLine("Student has admission to the exam");
    }
}



