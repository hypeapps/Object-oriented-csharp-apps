using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile masz pieniedzy");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj walute (Dollar, Euro, GBP)");
            String currency = Console.ReadLine();
            Bank bank = new Bank(currency, money);
            Console.WriteLine(bank.ShowMoney());
            Console.ReadKey();
            
        }
    }
}
