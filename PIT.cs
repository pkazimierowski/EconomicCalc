

/**
 * Class Pit includes objects and methots that allows user to calculate their taxes.
 * Taken variables are
 * Taxed_value - the ammount of income money the tax will be calculated from
 * Costs - cots of the income that are subtracted from taxed_value
 * ap - shortcut for advanced payments witch are subtracted from the final tax value
 * 
 * Author Dawid Górny
 */


class Pit
{
    double healthcare = 0.0775d;
    //Healthcare tax cannot be changed by user because its value its awlays 7,75% 
    public double podatekProgresywny(double taxed_value, double costs, double ap)
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

    public double podatekLinowy(double taxed_value, double costs, double ap)
    {

        double outcome = 0d;
        taxed_value = taxed_value - costs;
        taxed_value = taxed_value - healthcare;
        outcome = (taxed_value - (taxed_value * 0.19d)) - ap;
        return outcome;
    }

    public double Ryczalt(double procent, double taxed_value, double costs, double ap)
    {

        double outcome = 0d;
        taxed_value = taxed_value - costs;
        taxed_value = taxed_value - taxed_value;
        outcome = (taxed_value - (taxed_value * (procent * (0.01))) -ap);
        return outcome;
    }
}
