﻿using System.Collections.Generic;

namespace NotchCityLighting.Common.DataAccess
{
    public interface ILookupRepositoryBase<TLookupEntity, TKnownValues>
    {
        TLookupEntity GetByKey(int key);
        TLookupEntity GetByCode(string code);
        TLookupEntity GetKnownValue(TKnownValues knownValue);
        IEnumerable<TLookupEntity> GetAll();
    }
    public interface ILookupRepositoryBase<TLookupEntity>
    {
        IEnumerable<TLookupEntity> GetAll();
    }
}
