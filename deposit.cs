using System;



    /**
     * Class Deposit is a simple class containing methos witch allows user to calculate
     * their yearly income.
     * static double Progrsive caluclates progresive income using
     * static double Statik calculates static income witch means that first money amount always increae by the same base value
     *  Author - Dawid Górny
     */
    class Deposit
    {
        /**
        * money_amount = takes the amount of inveted money
        * increase = procentage increase;
        * time_years = allows to calculate income over time, eq 10 years
        */
        static double Progresive(double money_amount,double increase, double time_years)
        {
            for (int i = 0; i < time_years; i++)
            {
                money_amount += money_amount * (increase * 0.01);
            }
            return money_amount;
        }
        static double Statik(double money_amount,double increase, double time_years)
        {
            double value = money_amount * (increase * 0.01);
            for (int i = 0; i < time_years; i++)
            {
                money_amount = money_amount + value;
            }
            return money_amount;
        }
    }

