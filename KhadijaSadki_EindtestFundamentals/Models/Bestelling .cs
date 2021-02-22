using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhadijaSadki_EindtestFundamentals.Models
{
    public class Bestelling
    {
        public List<Product> Products= new List<Product>();
        public static int Product { get; set; } = 1000;

        private List<Product> bestelling;

        public List<Product> GetBestelling()
        {
            return bestelling;
        }

        public void SetBestelling(List<Product> value)
        {
            bestelling = value;
        }

        public Bestelling(List<Product> bestelling)
        {
            SetBestelling(bestelling);
        }

        public Bestelling (Product product)
        {
            SetBestelling(new List<Product>());
           
        }
        

            



    }
}
