using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotchCityLighting.Web.Unity
{
    public class UnityConfig
    {
        public static void RegisterUnity()
        {
            var container = UnityWebCommon.GetUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}