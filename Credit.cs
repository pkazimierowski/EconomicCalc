using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EconomicCalc

{
    static class Credit
    {
        //obliczanie kwoty kredytu bez prowizji 
        static public double Installment(double AmountOfCredit, double Interest, double NumberOfInstallments)
        {
            double q = 1 + ((Interest / 100) / 12);
            double LoanInstallment = AmountOfCredit * Math.Pow(q, NumberOfInstallments) * (q - 1) / (Math.Pow(q, NumberOfInstallments) - 1);
            return Math.Round(LoanInstallment, 2);
        }

        //z prowizją od kwoty netto

        static public double InstallmentNetto(double AmountOfCredit, double Interest, double NumberOfInstallments, double Commission)
        {
            AmountOfCredit = AmountOfCredit * (1 + (Commission / 100));
            double q = 1 + ((Interest / 100) / 12);
            double LoanInstallment = AmountOfCredit * Math.Pow(q, NumberOfInstallments) * (q - 1) / (Math.Pow(q, NumberOfInstallments) - 1);
            return Math.Round(LoanInstallment, 2);
        }

        //z prowizją do kwoty brutto
        static public double InstallmentBrutto(double AmountOfCredit, double Interest, double NumberOfInstallments, double Commission)
        {
            AmountOfCredit = AmountOfCredit / (1 - (Commission / 100));
            double q = 1 + ((Interest / 100) / 12);
            double LoanInstallment = AmountOfCredit * Math.Pow(q, NumberOfInstallments) * (q - 1) / (Math.Pow(q, NumberOfInstallments) - 1);
            return Math.Round(LoanInstallment, 2);
        }

    }
}

