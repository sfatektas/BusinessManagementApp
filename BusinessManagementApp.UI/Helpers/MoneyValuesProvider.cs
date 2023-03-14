using BusinessManagementApp.Common.Consts;
using BusinessManagementApp.UI.Helpers.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.UI.Helpers
{
    public static class MoneyValuesProvider
    {
        public static double Dolar { get; set; }
        public static double Euro { get; set; }
        static MoneyValuesProvider()
            //Burayı dinamik olarak bir tane apiden çekelim 
        {
            Task getvalue = GetValues();

        }
        public async static Task GetValues()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.genelpara.com/embed/doviz.json");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //Dolar = response.
                    var data = await response.Content.ReadAsStringAsync();
                    MoneyValueApiResponseModel model = JsonConvert.DeserializeObject<MoneyValueApiResponseModel>(data);
                    Euro = double.Parse(model.EUR.satis.Replace('.',','));
                    Dolar = double.Parse(model.USD.satis.Replace('.', ','));
                }
                else
                {
                    Dolar = double.Parse(ConfigurationManager.AppSettings["Dolar"]);
                    Euro = double.Parse(ConfigurationManager.AppSettings["Euro"]);
                }

            }
        }
    }
}
