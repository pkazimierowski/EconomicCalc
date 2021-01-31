namespace EconomicCalc
{

    static class Deposit
    {
        public static double lokataStatyczna(int okres, double procent, double kwota)
        {
            double wynik;
            wynik = kwota;
            procent = procent * 0.01d;
            for (int i = 0; i < okres; i++)
            {
                wynik += kwota * procent;
            }
            return wynik;
        }

        public static double lokataProgresywna(int okres, double procent, double kwota)
        {
            procent = procent * 0.01d;
            for (int i = 0; i < okres; i++)
            {
                kwota += kwota * procent;
            }
            return kwota;
        }
    }
}
