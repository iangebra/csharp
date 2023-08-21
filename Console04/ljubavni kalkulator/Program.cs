Console.Write("Vase ime: ");
string ime = Console.ReadLine();
Console.Write("Ime simpatije ");
string ime_simpatije = Console.ReadLine();

  int[] brojacslova = brojackalkulator(ime, ime_simpatije);        
  int[] rezultat = racunanjerezultata(brojacslova);
  ispisirezultat(rezultat);
    

    static int[] brojackalkulator(string ime, string ime_simpatije)
    {
        int[] ukupnoslova = new int[26]; 

        foreach (char slovo in ime + ime_simpatije)
        {
            if (char.IsLetter(slovo))
            {
                int index = slovo - 'a';
                ukupnoslova[index]++;
            }
        }

        return ukupnoslova;
    }

    static int[] racunanjerezultata(int[] ukpnoslovabrojac)
    {
        int[] ukupnoslova = new int[26];

        for (int i = 0; i < ukupnoslova.Length; i++)
        {
            ukupnoslova[i] = ukpnoslovabrojac[i] * (i + 1);
        }

        return ukupnoslova;
    }

    static void ispisirezultat(int[] rezultat)
    {
        for (int i = 0; i < rezultat.Length; i++)
        {
            Console.Write(rezultat[i] + " ");
        }
        Console.WriteLine();

        int sum = 0;
        for (int i = 0; i < rezultat.Length; i++)
        {
            sum += rezultat[i];
        }

        int rez = sum % 100;
        Console.WriteLine("Ukupni postotak: {0}% ", rez);
}