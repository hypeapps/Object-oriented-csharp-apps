using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiazka
{
    class Adres
    {
        public String Ulica { get; set; }
        public String NumerDomu { get; set; }
        public String NumerMieszkania { get; set; }
        public String KodPocztowy { get; set; }
        public String Miasto { get; set; }
        public String Panstwo { get; set; }

        public string MojAdres()
        {
            return "Ul. " + this.Ulica + this.NumerDomu + "/" + this.NumerMieszkania + "\n" +
            this.KodPocztowy + this.Miasto + "\n" +
            this.Panstwo;
        }
    }
}
