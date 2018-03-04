using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tieto.Models;

namespace Tieto
{
    public static class Helper
    {
        public enum BuildingType
        {
            Other = 0,
            Flat = 1,
            House = 2
        }

        public static HeatModel GetHeatData()         
        {
            HeatModel model = new HeatModel();
            HeatItem item = new HeatItem();
            item.Name = "Account1";
            item.Price = 20.5m;
            item.Temperatures = new double[] { 20.1, 22.3, 21.2 };

            model.Items.Add(item);

            item = new HeatItem();
            item.Name = "Account2";
            item.Price = 14.5m;
            item.Temperatures = new double[] { 22.1, 21.3, 20.2 };
            model.Items.Add(item);

            return model;
        }

        public static ElectricityModel GetElectricityData()
        {
            ElectricityModel model = new ElectricityModel();
            ElectricityItem item = new ElectricityItem();
            item.Name = "Account3";
            item.Price = 33.5m;
            item.Type = BuildingType.House;

            model.Items.Add(item);

            item = new ElectricityItem();
            item.Name = "Account4";
            item.Price = 34.2m;
            item.Type = BuildingType.Flat;

            model.Items.Add(item);

            item = new ElectricityItem();
            item.Name = "Account5";
            item.Price = 44.1m;
            item.Type = BuildingType.Other;
            model.Items.Add(item);

            return model;
        }
    }
}