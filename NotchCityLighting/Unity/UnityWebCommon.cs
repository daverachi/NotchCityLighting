using Microsoft.Practices.Unity;
using NotchCityLighting.Common.DataAccess;
using NotchCityLighting.Common.Unity;
using NotchCityLighting.Core.Repository;
using NotchCityLighting.Core.Service;
using System.Collections.Generic;
using System.Reflection;

namespace NotchCityLighting.Web.Unity
{
    public class UnityWebCommon
    {
        public static IUnityContainer GetUnityContainer()
        {
            var helper = new UnityHelper(GetAssembliesToLoad());
            var container = helper.Container;
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container = helper.BuildUnityContainer();
            return container;
        }

        internal static List<Assembly> GetAssembliesToLoad()
        {
            List<Assembly> assembliesToLoad = new List<Assembly>();
            //assembliesToLoad.Add(typeof(EntityBase).Assembly);
            assembliesToLoad.Add(typeof(LookupService).Assembly);
            assembliesToLoad.Add(Assembly.GetExecutingAssembly());

            return assembliesToLoad;
        }
    }
}