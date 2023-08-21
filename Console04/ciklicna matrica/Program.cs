Console.Write("Broj redaka: ");
int redovi = int.Parse(Console.ReadLine());

Console.Write("Broj stupaca: ");
int stupci = int.Parse(Console.ReadLine());
{
        int[,] matrica = new int[redovi, stupci];
        int value = 1;
        int prvired = 0, zadnjired = redovi - 1, prvistupac = 0, zadnjistupac = stupci - 1;

        while (prvired <= zadnjired && prvistupac <= zadnjistupac)
        {
            

            for (int i = zadnjistupac; i >= prvistupac; i--)
            {
                matrica[zadnjired, i] = value++;
            }
            zadnjired--;

            if (prvistupac <= zadnjistupac)
            {
                for (int i = zadnjired; i >= prvired; i--)
                {
                    matrica[i, prvistupac] = value++;
                }
                prvistupac++;
            }

            if (prvired <= zadnjired)
            {
                for (int i = prvistupac; i <= zadnjistupac; i++)
                {
                    matrica[prvired, i] = value++;
                }
                prvired++;
                for (int i = prvired; i <= zadnjired; i++)
                {
                    matrica[i, zadnjistupac] = value++;
                }
                zadnjistupac--;
            }
        }
        
        for (int i = 0; i < redovi; i++)
        {
            for (int j = 0; j < stupci; j++)
            {
                Console.Write(matrica[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }