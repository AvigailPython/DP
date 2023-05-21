using DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.ReportDecoraor
{
    public interface IReport
    {
        public void WriteReport(List<Product> soldProducts);
    }
}
