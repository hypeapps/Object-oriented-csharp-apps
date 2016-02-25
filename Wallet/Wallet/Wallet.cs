using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    class Wallet
    {
        public double Money { get; set; }
        public int WalletCapacity { get; set; }
        public String Currency { get; set; }
        public Bank Bank { get; set; }

        public Wallet()
        {
            this.Currency = "$";
            this.WalletCapacity = 300;
        }

        public Wallet(double money)
        {
            this.Money = money;
        }

        public Wallet(String currency)
        {
            this.Currency = currency;
        }
        public Wallet(String currency, double money)
            : this(currency) {
                this.Money = money;
        }

        public Wallet(double money, int walletCapacity)
            :this(money)
        {
            this.WalletCapacity = walletCapacity;
        }

        public String ShowMoney()
        {
            return this.Money + " " + this.Currency + "s";
        }

        public double WithdrawMoney(double minusMoney)
        {
            return this.Money - minusMoney;
        }



    }
}
