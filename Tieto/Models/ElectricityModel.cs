using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Tieto.Models
{
    [Serializable]
    [DataContract]
    public class ElectricityModel
    {
        [DataMember]
        public List<ElectricityItem> Items = new List<ElectricityItem>();        
    }

    [Serializable]
    [DataContract]
    public class ElectricityItem : BaseModel
    {

        private Helper.BuildingType type = 0;

        [DataMember]
        public Helper.BuildingType Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}