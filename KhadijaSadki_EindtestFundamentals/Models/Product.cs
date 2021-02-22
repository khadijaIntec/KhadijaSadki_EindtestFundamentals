using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhadijaSadki_EindtestFundamentals.Models
{
    public abstract class Product : IComparable<Product>
    {
        public int ProductNummer { get; set; }
        public string Merk { get; set; }
        public int Volume { get; set; }
        public double Prijs { get; set; }
        public string Naam { get; set; }
        public string Code { get; set; }

        public Product(int productnummer, string merk, int volume, double prijs, string naam, string Code)
        {
            ProductNummer = productnummer;
            Merk = merk;
            Volume = volume;
            Prijs = prijs;
            Naam = naam;
            this.Code = Code;
        }

        protected Product(string merk, string naam, int volume, double prijs)
        {
            Merk = merk;
            Naam = naam;
            Volume = volume;
            Prijs = prijs;
        }

        public int CompareTo(Product other)
        {
            return Merk.CompareTo(other.Merk);
        }
        public override string ToString()
        {
            
            return ProductNummer + "Merk:" + Merk + "Volume:" + Volume + "prijs:" + Prijs + "name" + Naam + "code" + Code;

              
        }

        public string GetProductCode()
        {
            string code = "";

            code += Merk.Substring(0, 2);
            code += Naam.Substring(0, 2);
            code += Volume;


            code.Replace(' ', '_');
            return code.ToUpper();
           
        }
    }
   }


