using System;
using System.Collections.Generic;
using System.Text;

namespace EconomicCalc
{
    public class Exchange
    {
        private JsonHandler_NBPExchangeRate DataFromNBP;
        private List<Rate> JsonList;
        protected String[] currency;
        public Exchange()
        {
            DataFromNBP = new JsonHandler_NBPExchangeRate();
        }


        public async System.Threading.Tasks.Task connectNbpApiAsync()
        {

            await DataFromNBP.ConverJsonToList();
            JsonList = DataFromNBP.GetRootObjects()[0].rates;
        }

        private double ConvertCurrency(double amount, double currency)
        {
            double result = 0.0d;
            result = amount * currency;
            return result;
        }

        public double Buy(double amount, int currency)
        {
            double result = 0.0d;
            result = amount * GetCurrencyBuyCost(currency);
            return result;
        }
        public double Sell(double amount, int currency)
        {
            double result = 0.0d;
            result = amount * GetCurrencySellCost(currency);
            return result;
        }
        public int GetAmountCurrencys()
        {
            return JsonList.Count;
        }
        public string GetCurrencyCode(int currency)
        {
            String result = JsonList[currency].code;
            return result;
        }
        public string GetCurrencyName(int currency)
        {
            String result = JsonList[currency].currency;
            return result;
        }
        public double GetCurrencyBuyCost(int currency)
        {
            double result = JsonList[currency].ask;
            return result;
        }
        public double GetCurrencySellCost(int currency)
        {
            double result = JsonList[currency].bid;
            return result;
        }


    }
}