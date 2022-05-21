using OMISWS_DataModel.Models;
using System.Xml;
using System.Xml.Serialization;
using static OMISWS_DataModel.XmlModels.RecivePaymentXmlModel;

namespace OMISWS_ServiceHub.Services
{
    public partial class RecivePaymentService : IRecivePaymentService
    {
        public string getxml(List<RecivePaymentDataModel> data)
        {

            var dc2 = new List<xmlRDmodel>();

            var dc = new List<xmlRmodel>();



            foreach (var item in data)
            {
                int i = 0;
                while (i < item.RD.Count)
                {
                    dc2.Add(new xmlRDmodel()
                    {
                        HID = item.RD[i].HID,
                        IID = item.RD[i].IID,
                        PRC = item.RD[i].PRC,
                        IDISC = item.RD[i].IDISC,
                        P = item.RD[i].P,
                        TAX = item.RD[i].TAX,
                        T2 = item.RD[i].T2,
                        PRC1 = item.RD[i].PRC1,
                        T21 = item.RD[i].T21

                    }); i++;
                }
            }

            foreach (var item in data)
            {
                dc.Add(new xmlRmodel()
                {
                    HID = item.HID,
                    PC = item.PC,
                    RPT = item.RPT,
                    RPC = item.RPC,
                    T2 = item.T2,
                    ET = item.ET,

                    RD = dc2

                }); ;
            }



            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    R = dc
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
