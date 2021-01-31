namespace EconomicCalc
{
    /**
 * Class Deposit is a simple class containing methos witch allows user to calculate
 * their yearly income.
 * static double lokataProgresywna caluclates progresive income
 * static double lokataStatyczna calculates static income witch means that first money amount always increase by the same base value
 *  Author - Dawid Górny
 */
    static class Deposit
    {
        public static double lokataStatyczna(int time_years, double procent, double money_amount)
        {
            /**
            * money_amount = takes the amount of inveted money
            * procent = procentage increase;
            * time_years = allows to calculate income over time, eq 10 years
            */
            double wynik;
            wynik = money_amount;
            procent = procent * 0.01d;
            for (int i = 0; i < time_years; i++)
            {
                wynik += money_amount * procent;
            }
            return wynik;
        }

        public static double lokataProgresywna(int time_years, double procent, double money_amount)
        {
            procent = procent * 0.01d;
            for (int i = 0; i < time_years; i++)
            {
                money_amount += money_amount * procent;
            }
            return money_amount;
        }
    }
}
