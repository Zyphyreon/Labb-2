using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Både kund och produkt ska vara separata klasser med Properties för information och metoder för att räkna ut
// totalpris och verifiera lösenord.
namespace Labb_2
{
    public class Product
    {
        //private string Name { get;  set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //private double Price { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }


        


    }

}
