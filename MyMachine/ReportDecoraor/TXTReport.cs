using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP;


namespace MyMachine.ReportDecoraor
{
    public class TXTReport : IReport
    {
        public const string PATH = "...\\...\\...\\...\\...\\DailyReport.txt";

        public void WriteReport(List<Product> soldProducts)
        {
            string Report = "";
            foreach (var product in soldProducts)
            {
                Report += $"{product.Name}\n"; 
            }
            File.AppendAllText(PATH, Report);
        }

    }
}
