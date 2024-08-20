// See https://aka.ms/new-console-template for more information
class Assignment8
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of the month");
        int month = int.Parse(Console.ReadLine());
        switch(month)
        {
            case 1: Console.WriteLine("january");break;
            case 2: Console.WriteLine("february");break;
            case 3: Console.WriteLine("march");break;
            case 4: Console.WriteLine("apirl");break;
            case 5: Console.WriteLine("may");break;
            case 6: Console.WriteLine("june");break;
            case 7: Console.WriteLine("july");break;
            case 8: Console.WriteLine("august");break;
            case 9: Console.WriteLine("spetember");break;
            case 10: Console.WriteLine("october");break;
            case 11: Console.WriteLine("november");break;
            case 12: Console.WriteLine("december");break;
            default: Console.WriteLine("invalid option");break;
        }
    }
}