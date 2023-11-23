// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number (from 0 to 9):");
var num = int.Parse(Console.ReadLine());
if (num is >= 0 and <= 9)
{
    switch (num)
    {
        case 1:
            Console.WriteLine("Один");
            break;
        case 2:
            Console.WriteLine("Два");
            break;
        case 3:
            Console.WriteLine("Три");
            break;
        case 4:
            Console.WriteLine("Чотири");
            break;
        case 5:
            Console.WriteLine("Пять");
            break;
        case 6:
            Console.WriteLine("Шість");
            break;
        case 7:
            Console.WriteLine("Сім");
            break;
        case 8:
            Console.WriteLine("Вісім");
            break;
        case 9:
            Console.WriteLine("Дев'ять");
            break;
    }
}