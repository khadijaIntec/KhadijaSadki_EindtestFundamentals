using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KhadijaSadki_EindtestFundamentals.Models
{

    public enum Soort
    {
        VAPO,
        GEL
    }

    public class AfterShave : Product
    {
        public Soort soort { get; set; }
        public AfterShave(string merk, string naam, Soort soort,int Volume, double prijs): base(merk, naam, Volume, prijs)
        {
            this.soort = soort;    
        }
        public override string ToString() => $"{ProductNummer.ToString().PadLeft(0)}" +
                $"Merk: {Merk.PadRight(20)}" +
                $"Naam: {Naam.PadRight(28)}" +
                $"Volume: {Volume}ML".PadRight(26) +
                $"Prijs: {Prijs}$".PadRight(26) +
                //$"Code: {Getcode().PadRight(24)}" +
                $"{soort}";

    }

}