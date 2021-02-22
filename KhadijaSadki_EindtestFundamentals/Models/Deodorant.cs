using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KhadijaSadki_EindtestFundamentals.Models
{
   
      public enum DeoType
       {
         VAPO,
         STICK
       }
        public class Deodorant : Product
        {
            public DeoType deoType { get; set; }
            public Deodorant(string merk, string naam,DeoType deotype, int volume, double prijs): base(merk,naam,volume,prijs)
        {
            this.deoType = deoType;
            


        }
        public override string ToString()
        {
            return $"{ProductNummer} Merk: {Merk} Naam:{Naam} Volume: {Volume} prijs:{Prijs} code: {GetProductCode()}{deoType}";
        }

       
    }



}

