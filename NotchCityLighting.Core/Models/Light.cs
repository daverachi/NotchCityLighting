using NotchCityLighting.Common.DataAccess;
using System;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Models
{
    public partial class Light : EntityBase
    {
        public Light()
        {
            this.LightParts = new List<LightPart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> SoldPrice { get; set; }
        public Nullable<System.DateTime> SoldDateTime { get; set; }
        public virtual ICollection<LightPart> LightParts { get; set; }
    }
}
