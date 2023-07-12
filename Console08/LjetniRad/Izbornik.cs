﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LjetniRad
{
    internal class Izbornik
    {
        private ObradaSmjer ObradaSmjer;
        private ObradaPolaznik ObradaPolaznik;

        public Izbornik() 
        {
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Edunova Console APP v 1.0 *****");
            Console.WriteLine("*************************************");
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            
            switch(Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika: ",
                "Odabir mora biti 1 - 4.", 1, 4))
            {
                case 1:
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.WriteLine("rad s grupama");
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Hvala na korištenju, doviđenja");
                    break;

            }


        }

    }
}
