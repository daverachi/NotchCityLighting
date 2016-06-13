using NotchCityLighting.Core.Models;
using NotchCityLighting.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotchCityLighting.Web.ViewModelExtensions
{
    public static class Extensions
    {
        public static Light ToLight(this LightDO lightDO)
        {
            return new Light {
                Description = lightDO.Description,
                Name = lightDO.Name,
                Photo = lightDO.Photo,
                SalePrice = lightDO.SalePrice,
                SoldPrice = lightDO.SoldPrice
            };
        }
    }
}