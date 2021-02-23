using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhadijaSadki_EindtestFundamentals.Models
{
    public class SchrijfNaarBestand
    {
       
        public static void SchrijfLijstNaarBestand<T>(List<T> list, string path)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    list.ForEach(x => sw.WriteLine(x));
                }
            }
        }
    }
}
