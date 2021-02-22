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
        public static void LogActivity(string content)
        {

            File.AppendAllText("TextFiles/Bestellingen.txt.", content);
        }
    }
}