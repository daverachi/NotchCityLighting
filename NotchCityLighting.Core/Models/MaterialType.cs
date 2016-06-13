using NotchCityLighting.Common.DataAccess;
using System;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Models
{
    public partial class MaterialType : EntityBase
    {
        public MaterialType()
        {
            this.Parts = new List<Part>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}
