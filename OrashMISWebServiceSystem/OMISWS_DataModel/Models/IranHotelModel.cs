using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.Models
{
    
        public class IranHotelInputModel
        {
            public string custcode { get; set; }
            public string custname { get; set; }
            public string custprice { get; set; }
            public string custdesc { get; set; }
            public Int16 turnovercode { get; set; }
            public string date { get; set; }

            public List<IranHotelDataModel> supplier { get; set; }

            public List<IranHotelDataModel> bank { get; set; }
        }
        public class IranHotelDataModel
        {
            public string code { get; set; }
            public string name { get; set; }
            public double price { get; set; }
            public string desc { get; set; }
            //type = 1 بدهکار
            //type = 2 بستانکار
            public int Type { get; set; }
        }

    }

