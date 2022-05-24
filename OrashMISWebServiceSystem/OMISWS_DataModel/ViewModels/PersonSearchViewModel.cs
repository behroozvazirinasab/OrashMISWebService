using OMISWS_DataModel.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.ViewModels
{
    public class PersonSearchViewModel : IPersonBaseModel
    {
        public long? Code { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public Boolean? Persons { get; set; }
        public Boolean? Expence { get; set; }
        public Boolean? Bank { get; set; }
        public Boolean? Cash { get; set; }
        public Boolean? Tuner { get; set; }
        public long? PerType { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string EconomicCode { get; set; }
        public string NationalCode { get; set; }
        public string RegisterNo { get; set; }
        public string PostCode { get; set; }
        public string NationalNo { get; set; }
        public string Description { get; set; }
        public string ISActive { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
