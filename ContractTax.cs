using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EconomicCalc
{
   
        static class contract
        {
            static public double uop(double gross_salary)
            {
                double pension_insurance = gross_salary * 0.0957d;
                double disability_insurance = gross_salary * 0.015d;
                double medical_insurance = gross_salary * 0.0245d;
                double contribution_basis = gross_salary - medical_insurance - disability_insurance - pension_insurance;
                double obtain_cost = 250;
                double tax_base = gross_salary - medical_insurance - disability_insurance - pension_insurance - obtain_cost;
                double tax_relief = 43.76d;
                double tax_prepayment = (tax_base * 0.17d) - tax_relief;
                double health_insurance = contribution_basis * 0.09d;
                double deductible_health_insurance = contribution_basis * 0.0775d;
                double tax_for_the_tax_office = tax_prepayment - deductible_health_insurance;
                double net_payout = gross_salary - medical_insurance - disability_insurance - pension_insurance - health_insurance - tax_for_the_tax_office;
                return net_payout;

            }
            static public double uz(double gross_salary)
            {
                double pension_insurance = gross_salary * 0.0957d;
                double disability_insurance = gross_salary * 0.015d;
                double medical_insurance = gross_salary * 0.0245d;
                double sum_of_contributions = medical_insurance + pension_insurance + disability_insurance;
                double obtain_cost = (gross_salary - sum_of_contributions) * 0.2d;
                double health_composition = (gross_salary - sum_of_contributions) * 0.09d;
                double reduction_of_tax_prepayment = (gross_salary - sum_of_contributions) * 0.075d;
                double prepayment_income_tax = (((gross_salary - sum_of_contributions) - obtain_cost) * 0.18d) - reduction_of_tax_prepayment;
                double net_payout = gross_salary - (sum_of_contributions + health_composition + prepayment_income_tax);
                return net_payout;
            }

            static public double uod(double gross_salary)
            {
                double obtain_cost = gross_salary * 0.2d;
                double income = gross_salary - obtain_cost;
                double tax = income * 0.17d;
                double net_payout = gross_salary - tax;
                return net_payout;
            }

            static public double b2b(double gross_salary, double costs)
            {
                double vat = gross_salary * 0.23d;
                double net_income = gross_salary - vat;
                double vat_with_costs = vat - costs;
                if (vat_with_costs < 0)
                { vat_with_costs = 0; }
                double income_with_tax = gross_salary - vat_with_costs;
                double net_income_with_costs = net_income - costs;
                double tax_with_costs = net_income_with_costs * 0.17d;
                double zus = 1360;
                double net_payout = income_with_tax - tax_with_costs - zus;
                return net_payout;

            }


        }
    
}
