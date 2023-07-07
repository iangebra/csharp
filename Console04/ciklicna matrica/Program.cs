int redaka = 5, stupaca = 5;

int[,] matrica = new int[redaka, stupaca];

int b = 1;
string razmak;

//lijevo
for (int i = 1; i <= stupaca; i++)
{
    matrica[redaka - 1, stupaca - i] = b++;
}

//gore
for (int i = redaka - 2; i >= 0; i--)
{
    matrica[i, 0] = b++;
}

//desno
for (int i = 1; i <= stupaca - 1; i++)

{
    matrica[0, i] = b++;
}

//dole
for (int i = 1; i <= stupaca - 2; i++)
{
    matrica[i, stupaca - 1] = b++;
}

//opet lijevo
for (int i = 3; i >= stupaca - 4; i--)
{
    matrica[3, i] = b++;
}

//opet gore
for (int i = 2; i >= redaka - 4; i--)
{
    matrica[i, 1] = b++;
}

//opet desno
for (int i = 2; i <= stupaca - 2; i++)
{
    matrica[1, i] = b++;
}

//opet dole
for (int i = 2; i <= stupaca - 3; i++)
{
    matrica[i, stupaca - 2] = b++;
}

//jos jednom lijevo i ispis

for (int i = 3; i < stupaca - 1; i++)
{
    matrica[redaka - 3, stupaca - i] = b++;
}
for (int i = 0; i < redaka; i++)
{
    for (int j = 0; j < stupaca; j++)
    {
        razmak = "   " + matrica[i, j];
        Console.Write(razmak[^4..]);
    }
    Console.WriteLine();
}