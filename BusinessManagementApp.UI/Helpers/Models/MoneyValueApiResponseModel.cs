using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.UI.Helpers.Models
{
    public class MoneyValueApiResponseModel
    {
        public EUR EUR { get; set; }
        public USD USD { get; set; }
    }
    public abstract class Money
    {
        public string satis { get; set; }
        public string alis { get; set; }
        public string degisim { get; set; }
        public string d_oran { get; set; }
        public string d_yon { get; set; }
    }
    public class EUR : Money
    {

    }    
    public class USD : Money
    {

    }
}
