using NotchCityLighting.Common.DataAccess;
using System;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Models
{
    public partial class Part : EntityBase
    {
        public Part()
        {
            this.LightParts = new List<LightPart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaterialType { get; set; }
        public Nullable<int> MaximumWattage { get; set; }
        public decimal Cost { get; set; }
        public string ItemNumber { get; set; }
        public string LocationOfPurchase { get; set; }
        public string Photo { get; set; }
        public string Url { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public virtual ICollection<LightPart> LightParts { get; set; }
        public virtual MaterialType MaterialType1 { get; set; }
    }
}
