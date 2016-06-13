using System;

namespace NotchCityLighting.Common.DataAccess
{
    public abstract class EntityBase
    {
        public System.DateTime CreateDateTime { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}