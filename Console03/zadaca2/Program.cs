// Za unesena dva cijela broj
// program ispisuje veći
// 3 i 5 -> 5
// 5 i 3 -> 3
// 5 i 5 ->


using System.Collections.Generic;

Console.Write("unesi prvi broj: ");
int i = int.Parse(Console.ReadLine());
Console.Write("unesi drugi broj: ");
int j = int.Parse(Console.ReadLine());
if (i > j)
{
    Console.WriteLine(i);
}
else if (i == j)
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine(j);
}



// Za upisana 3 cijela broja
// program ispisuje najveći

int a = 5;
int b = 16;
int c = 2;
{
    if ((b < a) && (a > c))
    {
        Console.WriteLine("najveci je {0}", a);
    }

    else if ((a < b) && (b > c))
    {
        Console.WriteLine("najveci je {0}", b);
    }
    else
    {
        Console.WriteLine("najveci je {0}", c);
    }
}


// program unosi broj između 
// 1 i 999
// U slučaju da je izvan tog raspona
// ispisati grešku i prekinuti program
// Program ispisuje 1. znamenku upisanog broja

Console.Write("unesi broj izmedu 1 i 999: ");
i = int.Parse(Console.ReadLine());
if (i > 999 || i < 1)

{
    Console.WriteLine("greska");
}
else
{
    j = i / 100 + (i % 100 / i) * i / 10 + (i % 10 / i) * i;
    Console.WriteLine(j);
}

// Program unosi 2 broja
// Ako su oba broja parni
// ispisuje njihov zbroj
// inače ispisuje njihovu razliku

Console.Write("unesi prvi broj: ");
i= int.Parse(Console.ReadLine());
Console.Write("unesi drugi broj: ");
j= int.Parse(Console.ReadLine());


if (i % 2 == 0 && j % 2 == 0)
{
    int zbroj = i + j;
     Console.WriteLine("zbroj je: {0} ", zbroj);
}
else
{
    int razlika = i - j;
    Console.WriteLine("razlika je: {0} ", razlika);
}