using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Tieto.Models;

namespace Tieto.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ContractController : ApiController
    {
        public IHttpActionResult GetHeat()
        {
            HeatModel model = Helper.GetHeatData(); 
            return Ok(model);
        }

        public IHttpActionResult GetElectricity()
        {
            ElectricityModel model = Helper.GetElectricityData();
            return Ok(model);
        }
    }


}