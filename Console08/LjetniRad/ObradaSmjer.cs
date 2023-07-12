﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRad
{
    internal class ObradaSmjer
    {
        public List<Smjer> Smjerovi { get;  }

        public ObradaSmjer() 
        {
            Smjerovi = new List<Smjer>();
            TestniPodaci();
        
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s smjerovima");
            Console.WriteLine("1. Pregled postojećih smjerova");
            Console.WriteLine("2. Unos novo smjera");
            Console.WriteLine("3. Promjena postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch(Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika smjera: ",
                "Odabir mora biti 1-5", 1, 5))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s smjerovima");
                    break;
            }
        }

        private void UnosNovogSmjera()
        {
            var s = new Smjer();
            s.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra smjera: ",
                "Unos mora biti pozitivni cijeli broj");
            s.Naziv = Pomocno.UcitajString("Unesite naziv smjera: ",
                "Unos obavezan");
            s.Trajanje = Pomocno.ucitajCijeliBroj("unesi trajanje smjera u satima: ",
                "Unos mora biti cijeli pozitivni broj");
            // ostala svojstva kasnije
            Smjerovi.Add(s);

        }

        private void PrikaziSmjerove()
        {
            foreach(Smjer smjer in Smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }
        }

        private void TestniPodaci()
        {
            Smjerovi.Add(new Smjer { Naziv= "Web programiranje" });
        }
    }
}
