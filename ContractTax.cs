using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EconomicCalc
{
        class ContractTax
        {
            public double uop(double wynagrodzenieb)
            {
                double ubezpieczeniemerytalne = wynagrodzenieb * 0.0957d;
                double ubezpieczenierentowe = wynagrodzenieb * 0.015d;
                double ubezpieczeniechorobowe = wynagrodzenieb * 0.0245d;
                double podstawaskladki = wynagrodzenieb - ubezpieczeniechorobowe - ubezpieczenierentowe - ubezpieczeniemerytalne;
                double kosztuzyskania = 250;
                double podstawaopodatkowania = wynagrodzenieb - ubezpieczeniechorobowe - ubezpieczenierentowe - ubezpieczeniemerytalne - kosztuzyskania;
                double ulgapodatkowa = 43.76d;
                double zaliczkanapodatek = (podstawaopodatkowania * 0.17d) - ulgapodatkowa;
                double ubezpieczniezdrowotne = podstawaskladki * 0.09d;
                double ubezpieczeniezdrowotneodliczane = podstawaskladki * 0.0775d;
                double podatekurzadskarbowy = zaliczkanapodatek - ubezpieczeniezdrowotneodliczane;
                double dowyplaty = wynagrodzenieb - ubezpieczeniechorobowe - ubezpieczenierentowe - ubezpieczeniemerytalne - ubezpieczniezdrowotne - podatekurzadskarbowy;
                return dowyplaty;

            }
            public double uz(double wynagrodzenieb)
            {
                double ubezpieczeniemerytalne = wynagrodzenieb * 0.0957d;
                double ubezpieczenierentowe = wynagrodzenieb * 0.015d;
                double ubezpieczeniechorobowe = wynagrodzenieb * 0.0245d;
                double sumaskładek = ubezpieczeniechorobowe + ubezpieczeniemerytalne + ubezpieczenierentowe;
                double kosztuzyskania = (wynagrodzenieb - sumaskładek) * 0.2d;
                double składkazdrowotnazus = (wynagrodzenieb - sumaskładek) * 0.09d;
                double pomniejszeniezaliczkinapodatek = (wynagrodzenieb - sumaskładek) * 0.075d;
                double zaliczkanapodatekdochodowy = (((wynagrodzenieb - sumaskładek) - kosztuzyskania) * 0.18d) - pomniejszeniezaliczkinapodatek;
                double dowyplaty = wynagrodzenieb - (sumaskładek + składkazdrowotnazus + zaliczkanapodatekdochodowy);
                return dowyplaty;
            }

            public double uod(double wynagrodzenieb)
            {
                double kosztyuzyskania = wynagrodzenieb * 0.2d;
                double dochod = wynagrodzenieb - kosztyuzyskania;
                double podatek = dochod * 0.17d;
                double dowyplaty = wynagrodzenieb - podatek;
                return dowyplaty;
            }

            public double b2b(double wynagrodzenieb, double koszty)
            {
                double vat = wynagrodzenieb * 0.23d;
                double wynagrodzenienetto = wynagrodzenieb - vat;
                double vatzkosztami = vat - koszty;
                if (vatzkosztami < 0)
                { vatzkosztami = 0; }
                double wynagrodzeniepovacie = wynagrodzenieb - vatzkosztami;
                double wynagrodzenienettozkosztami = wynagrodzenienetto - koszty;
                double podatekzkosztami = wynagrodzenienettozkosztami * 0.17d;
                double zus = 1360;
                double dowyplaty = wynagrodzeniepovacie - podatekzkosztami - zus;
                return dowyplaty;

            }
        }
        static void Main(string[] args)
        {
            ContractTax test = new ContractTax();
            Console.WriteLine("wypłata " + test.b2b(12300, 0));

        }
}
