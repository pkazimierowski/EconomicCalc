using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicCalc
{
     class Pit
    {
        static double healthcare = 0.0775d;
        //Healthcare tax cannot be changed by user because its value its awlays 7,75% 
        static public double podatekProgresywny(double taxed_value, double costs, double ap)
        {

            double outcome = 0d;
            taxed_value = taxed_value - costs;
            taxed_value = taxed_value - healthcare;
            if (taxed_value <= 85528d)
            {
                outcome = (taxed_value - (taxed_value * 0.17d)) - ap;
                outcome = taxed_value - outcome;
                return outcome;
            }
            else
            {
                outcome = ((85528d * 0.17d) + ((taxed_value - 85528d) * 0.32d)) - ap;
                return outcome;
            }

        }

        static public double podatekLinowy(double taxed_value, double costs, double ap)
        {

            double outcome = 0d;
            taxed_value = taxed_value - costs;
            taxed_value = taxed_value - healthcare;
            outcome = (taxed_value - (taxed_value * 0.19d)) - ap;
            outcome = taxed_value - outcome;
            return outcome;
        }

        static public double Ryczalt(double taxed_value, double costs, double ap, double procent)
        {

            double outcome = 0d;
            taxed_value = taxed_value - costs;
            taxed_value = taxed_value - taxed_value;
            outcome += (taxed_value - (taxed_value * (procent * (0.01d))) - ap);
            return outcome;
        }
    }
}
