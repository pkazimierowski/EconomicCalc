using System;
using System.Collections.Generic;
using System.Text;

namespace EconomicCalc
{

    /**
     * Class for calculate currency prices
     * 
     * @author Patryk Kazimieorkwsi
     */
    public class Exchange
    {
        private JsonHandler_NBPExchangeRate DataFromNBP;
        private List<Rate> JsonList;
        protected String[] currency;

        /**
         * Constructor
         */
        public Exchange()
        {
            DataFromNBP = new JsonHandler_NBPExchangeRate();
        }

        /**
         * Async method for connecting witch NBP api 
         */
        public async System.Threading.Tasks.Task connectNbpApiAsync()
        {

            await DataFromNBP.ConverJsonToList();
            JsonList = DataFromNBP.GetRootObjects()[0].rates;
        }

        /**
         * Method for calculate buy proces
         * 
         * @param amount
         *          value we wanto to buy
         * @param currency
         *          currency we want ot buy
         * @return
         *          buy price
         */
        public double Buy(double amount, int currency)
        {
            double result = 0.0d;
            result = amount * GetCurrencyBuyCost(currency);
            return result;
        }
        /**
         * Method for calculate sell proces
         * 
         * @param amount
         *          value we wanto to sell
         * @param currency
         *          currency we want ot sell
         * @return result
         *          sell price
         */
        public double Sell(double amount, int currency)
        {
            double result = 0.0d;
            result = amount * GetCurrencySellCost(currency);
            return result;
        }
        /**
         * @return JsonList.Count
         *      the number o currencys downloaded from NBP api
         */
        public int GetAmountCurrencys()
        {
            return JsonList.Count;
        }
        /**
         * method for read code a downloaded currency by id
         * @param currency
         *      the currency id
         * @return result
         *      the currency code 
         */
        public string GetCurrencyCode(int currency)
        {
            String result = JsonList[currency].code;
            return result;
        }
        /**
         * method for read name a downloaded currency by id
         * @param currency
         *      the currency id
         * @return result
         *      the currency name 
         */
        public string GetCurrencyName(int currency)
        {
            String result = JsonList[currency].currency;
            return result;
        }
        /**
         * method for read buy cost a downloaded currency by id
         * @param currency
         *      the currency id
         * @return result
         *      the currency buy cost 
         */
        public double GetCurrencyBuyCost(int currency)
        {
            double result = JsonList[currency].ask;
            return result;
        }
        /**
         * method for read sell cost a downloaded currency by id
         * @param currency
         *      the currency id
         * @return result
         *      the currency sell cost 
         */
        public double GetCurrencySellCost(int currency)
        {
            double result = JsonList[currency].bid;
            return result;
        }


    }
}