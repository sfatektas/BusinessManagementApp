using BusinessManagementApp.Common.Consts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.UI.Helpers
{
    public static class MoneyValuesProvider
    {
        public static double Dolar { get; set; }
        public static double Euro { get; set; }
        static MoneyValuesProvider()
        {
            Dolar = double.Parse(ConfigurationManager.AppSettings["Dolar"]);
            Euro = double.Parse(ConfigurationManager.AppSettings["Euro"]); 
        }
    }
}
