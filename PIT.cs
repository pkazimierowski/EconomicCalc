class Pit
{
    double ubezpieczenie = 0.0775d;
    //Cena ubezpieczenia zdrowotnego wynosi 7.75% dlatego jest sztywno ustalona
    public double podatekProgresywny(double kwota_podatku, double koszty, double zaliczki)
    {
        /**
         * Pobierane wartosci to kolejno kwota_podatku - odpowiada za główną 
         * wartość od której będziemy odejmować kolejne wartości aby otrzymać wyliczony podatek PIT
         * koszty = Odpowiadają za koszt uzyskania przychodu. Podczas obliczen są odejmowane od kwota_podatku
         * zaliczki - odpowiadają za wpłacone juz zaliczki podatkowe, odejmowane są od końcowego wyniku
         */
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
        /**
         * Zasada działania taka sama jak przy podatku progresywnym, 
         * różnica pojawia się jedynie podczas wykonywania obliczeń
         */
        double wynik = 0d;
        kwota_podatku = kwota_podatku - koszty;
        kwota_podatku = kwota_podatku - ubezpieczenie;
        wynik = (kwota_podatku - (kwota_podatku * 0.19d)) - zaliczki;
        return wynik;
    }

    public double Ryczalt(double procent, double kwota_podatku, double koszty, double zaliczki)
    {
        /**
         * W tym przypadku dochodzi jeszcze wartosc procent
         * która dzial mniej wiecej tak jak gdybysmy przyjeli stope oprocentowania ryczaltu
         * jako próg podatkowy 
         */
        double wynik = 0;
        kwota_podatku = kwota_podatku - koszty;
        kwota_podatku = kwota_podatku - ubezpieczenie;
        wynik = (kwota_podatku - (kwota_podatku * (procent * (0.01))) - zaliczki);
        return wynik;
    }
}
