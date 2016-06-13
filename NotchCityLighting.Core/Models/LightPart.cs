using NotchCityLighting.Common.DataAccess;
using System;
using System.Collections.Generic;

namespace NotchCityLighting.Core.Models
{
    public partial class LightPart : EntityBase
    {
        public int Id { get; set; }
        public int LightId { get; set; }
        public int PartId { get; set; }
        public virtual Light Light { get; set; }
        public virtual Part Part { get; set; }
    }
}
