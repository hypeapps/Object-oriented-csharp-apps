using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    class Bank
    {
        private string currency;
        private double money;

        public double ExchangeRateDollar { get; set; }
        public double ExchangeRateEuro {get; set;}
        public double ExchangeRateGBP {get; set;}
        public Wallet Wallet { get; set; }
        
        public Bank(String currency, double money)
        {
            this.Wallet = new Wallet(currency, money);
            this.Wallet.Money = money;
            this.Wallet.Currency = currency;
        }

        public String ShowMoney()
        {
            return this.Wallet.ShowMoney();
        }
        public void SetExchangeRate(String exchangeRateName, double exchangeRate)
        {
            if (exchangeRateName.Equals("Dollar"))
            {
                this.ExchangeRateDollar = exchangeRate;
            }
            else if (exchangeRateName.Equals("Euro"))
            {
                this.ExchangeRateEuro = exchangeRate;
            }
            else if (exchangeRateName.Equals("GBP"))
            {
                this.ExchangeRateGBP = exchangeRate;
            }
        }

        public double ExchangePLN(String exchangeRateName, double money)
        {
            if (exchangeRateName.Equals("Dollar"))
            {
                return money * ExchangeRateDollar;
            }
            else if(exchangeRateName.Equals("Euro"))
            {
                return money * ExchangeRateEuro;
            }
            else if (exchangeRateName.Equals("GBP"))
            {
                return money * ExchangeRateGBP;
            }
            return 0; 
        }
    }
}
