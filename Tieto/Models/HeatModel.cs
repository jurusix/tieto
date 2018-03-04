using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Tieto.Models
{

    [Serializable]
    [DataContract]
    public class HeatModel
    {
        [DataMember]
        public List<HeatItem> Items = new List<HeatItem>();
    }


    [Serializable]
    [DataContract]
    public class HeatItem : BaseModel
    {

        private double[] temperatures = null;

        [DataMember]
        public double[] Temperatures
        {
            get { return temperatures; }
            set { temperatures = value; }
        }

    }
}