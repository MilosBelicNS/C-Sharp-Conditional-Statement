using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statement.Practice
{
    class _16
    {
        //Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. 
        //The charge are as follow:


        public static void Main (string [] args)
        {
            int IdKorisnika, kw;
            double tarifa = 0;
            double cena; 
            double ukupnaCena;
            double dodatak;
            string korisnik;

            Console.WriteLine("Izracunavanje racuna za struju: ");
            Console.WriteLine("-------------------------------------");

            Console.Write("Unesite Id korisnika: ");
            IdKorisnika = Convert.ToInt32(Console.ReadLine());

            Console.Write("Unesite utrosak u kw: ");
            kw = Convert.ToInt32(Console.ReadLine());

            Console.Write("Unesite ime korisnika: ");
            korisnik = Convert.ToString(Console.ReadLine());

           

            if(kw < 199)
            {
                tarifa = 1.20;
            }else if(kw >= 200 && kw < 400)
            {
                tarifa = 1.50;
            }else if(kw >= 400 && kw < 600)
            {
                tarifa = 1.80;
            }else if(kw >= 600)
            {
                tarifa = 2.00;
            }

            cena = kw * tarifa;
            dodatak = cena * 15 / 100;

            if (cena > 300)
            {
                ukupnaCena = cena + dodatak;

            }
            else ukupnaCena = cena; dodatak = 0;
            Console.WriteLine("Racun za struju");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Korisnikov Id: {0}", IdKorisnika);
            Console.WriteLine("Korisnikovo ime: {0}", korisnik);
            Console.WriteLine("Potroseno kw: {0}", kw);
            Console.WriteLine("Tarifa po utrosenom kw je {0}, a cena potrosenih kw je: {1}", tarifa, cena);
            Console.WriteLine("Dodatnih 15% po ovom racunu je : {0}", dodatak);
            Console.WriteLine("Ukupna cena racuna je: {0}", ukupnaCena);
            Console.ReadKey();


        }
    }
}

