using OMISWS_DataModel.Models;
using OMISWS_DataModel.XmlModels;
using System.Xml;
using System.Xml.Serialization;

namespace OMISWS_ServiceHub.Services
{
    public partial class IranHotelService
    {
        public string getxml(List<IranHotelDataModel> data)
        {
            var dc = new List<xmlModel>();
            foreach (var item in data)
            {
                dc.Add(new xmlModel()
                {
                    Code = item.code,
                    Name = item.name,
                    DE = item.desc,
                    Price = item.price,
                    Type = item.Type
                });
            }

            var rModel = new rootmodel()
            {
                root = new RootObject()
                {
                    H = dc
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
