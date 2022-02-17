Console.WriteLine("Number of leap years to be found: ");
int rep = Convert.ToInt32(Console.ReadLine())+1;
Console.WriteLine("Year to start from: ");
int year = Convert.ToInt32(Console.ReadLine());
int x = 0;
foreach (int value in Enumerable.Range(year, 4*rep+4))
{
    if ((value % 400 == 0))
    {
        if ((value % 100) == 0)
            Console.WriteLine(x + ": " + value + " is a leap year");
             x = x + 1;
        if (x == rep)
        {
            break;

        }
    }
    else if ((value % 4 == 0))
    {
        if ((value % 100 != 0))
        { 
            Console.WriteLine(x + ": " + value + " is a leap year");
        x = x + 1;
        if (x == rep)
        {
            break;
        }
    }
    }
}
