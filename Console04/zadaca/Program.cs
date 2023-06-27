Console.Write("Upisi ime: ");
string ime = Console.ReadLine();
string s;
Console.WriteLine("-------------------------------");
Console.WriteLine(": : :  TABLICA  MNOZENJA  : : :");
Console.WriteLine("-------------------------------");
Console.Write(" * |");
for (int i = 1;i < 10; i++)
{
    Console.Write("  " + i);
}
Console.WriteLine();
Console.WriteLine("-------------------------------");
for (int j = 1; j < 10; j++)
{
    Console.Write(" " + j + " |");
    for (int k = 1; k < 10; k++)
    {
        s = "   " + j * k;
        Console.Write(s[^3..]);
    }
    Console.WriteLine();
}
Console.WriteLine("-------------------------------");
s = ":  :  :  :  :  :  :  :  :  : by " + ime;
Console.Write(s[^31..]);
Console.WriteLine();
Console.WriteLine("-------------------------------");