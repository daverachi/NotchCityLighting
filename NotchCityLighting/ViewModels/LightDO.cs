using NotchCityLighting.Core.Models;
using System;
using System.Collections.Generic;

namespace NotchCityLighting.Web.ViewModels
{
    public class LightDO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? SoldPrice { get; set; }
        public DateTime? SoldDateTime { get; set; }
        public IEnumerable<Part> LightParts { get; set; }
        public string Message { get; set; }
    }
}