﻿
int i = 2;

if (i == 1)
{
    Console.WriteLine("Dobro");
}
else if (i == 2)
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("Ostalo");
}

// višestruko grananje
int ocjena = 3;

switch (ocjena)
{
    case 1:
        Console.WriteLine("Nedovoljan");
        break;
    case 2:
        Console.WriteLine("Dovoljan");
        break;
    case 3:
        Console.WriteLine("Dobar");
        break;
    case 4:
        Console.WriteLine("Vrlo dobar");
        break;
    case 5:
        Console.WriteLine("Izvrstan");
        break;
    default:
        Console.WriteLine("Nije ocjena");
        break;
}


// 1. Zadatak
// Program unosi ime mjesta iz jedne od 4 slavonske županije
// Za uneseno ime mjesta program ispisuje ime županije

Console.WriteLine("unesi ime grada");
string grad = (Console.ReadLine());

switch (grad)
{
    case "osijek":
        Console.WriteLine("osjecko baranjska");
        break;

    case "vukovar":
        Console.WriteLine("vukovarsko srijemska");
        break;
    case "slavonski brod":
        Console.WriteLine("brodsko posavska");
        break;
    case "pozega":
        Console.WriteLine("pozensko slavonska");
        break;

    default:
        Console.WriteLine("neispravan grad");
        break;
}

