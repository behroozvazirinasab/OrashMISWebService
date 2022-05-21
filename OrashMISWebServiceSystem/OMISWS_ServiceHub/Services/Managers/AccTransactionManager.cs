using OMISWS_DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static OMISWS_DataModel.XmlModels.AccTransactionXmlModel;

namespace OMISWS_ServiceHub.Services
{
    public partial class AccTransactionService
    {
        public string getxml(List<FactorDataModel> data)
        {

            var dc2 = new List<xmlADmodel>();

            var dc = new List<xmlAmodel>();



            foreach (var item in data)
            {
                int i = 0;
                while (i < item.AD.Count)
                {
                    dc2.Add(new xmlADmodel()
                    {
                        HID = item.AD[i].HID,
                        IID = item.AD[i].IID,
                        ROW = item.AD[i].ROW,
                        KL = item.AD[i].KL,
                        MN = item.AD[i].MN,
                        TC = item.AD[i].TC,
                        IDE = item.AD[i].IDE,
                        D = item.AD[i].D,
                        C = item.AD[i].C,
                        T2 = item.AD[i].T2

                    }); i++;
                }
            }

            foreach (var item in data)
            {
                dc.Add(new xmlAmodel()
                {
                    HID = item.HID,
                    ANO = item.ANO,
                    HDEC = item.HDEC,


                    AD = dc2

                });

            }



            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    A = dc
                }
            };



            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(rootmodel));

            xs.Serialize(sw, rModel);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sw.ToString());
            XmlNodeList nodes = doc.SelectNodes("//rootmodel");

            return doc.FirstChild.NextSibling.InnerXml;
        }
    }
}
