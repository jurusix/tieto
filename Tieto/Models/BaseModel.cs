using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Tieto.Models
{
    [Serializable]
    [DataContract]
    public class BaseModel
    {
        private string name = null;
        private decimal price = 0m;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}