using System;

class Pit
{
    double ubezpieczenie = 0.0775d;
    public double podatekProgresywny(double kwota_podatku, double koszty, double zaliczki)
    {
        double wynik = 0d;
        kwota_podatku = kwota_podatku - koszty;
        kwota_podatku = kwota_podatku - ubezpieczenie;
        if (kwota_podatku <= 85528d)
        {
            wynik = (kwota_podatku - (kwota_podatku * 0.17d)) - zaliczki;
            wynik = kwota_podatku - wynik;
            return wynik;
        }
        else
        {
            wynik = ((85528d * 0.17d) + ((kwota_podatku - 85528d) * 0.32d)) - zaliczki;
            return wynik;
        }

    }

    public double podatekLinowy(double kwota_podatku, double koszty, double zaliczki)
    {
        double wynik = 0d;
        kwota_podatku = kwota_podatku - koszty;
        kwota_podatku = kwota_podatku - ubezpieczenie;
        wynik = (kwota_podatku - (kwota_podatku * 0.19d)) - zaliczki;
        return wynik;
    }

    public double Ryczalt(double procent, double kwota_podatku, double koszty, double zaliczki)
    {
        double wynik = 0;
        kwota_podatku = kwota_podatku - koszty;
        kwota_podatku = kwota_podatku - ubezpieczenie;
        wynik = (kwota_podatku - (kwota_podatku * (procent * (0.01))) - zaliczki);
        return wynik;
    }
}
