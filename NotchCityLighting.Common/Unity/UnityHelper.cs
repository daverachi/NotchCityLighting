using Microsoft.Practices.Unity;
using NotchCityLighting.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotchCityLighting.Common.Unity
{
    public class UnityHelper
    {
        public List<Assembly> _AssembliesToScan = new List<Assembly>();
        IUnityContainer container = new UnityContainer();

        public UnityHelper(List<Assembly> AssembliesToScan)
        {
            _AssembliesToScan = AssembliesToScan;
        }

        public IUnityContainer Container { get { return container; } }

        public virtual IUnityContainer BuildUnityContainer()
        {
            ConventionConfiguration(container);
            return container;
        }

        private void ConventionConfiguration(IUnityContainer container)
        {
            foreach (var asm in _AssembliesToScan)
            {
                var interfaces = asm.GetInterfaces();

                foreach (var interfaceType in interfaces)
                {
                    var currentInterfaceType = interfaceType;
                    var implementations = asm.GetImplementationsOfInterface(interfaceType);
                    if (implementations.Count > 0)
                    {
                        if (!container.IsRegistered(currentInterfaceType))
                        {
                            container.RegisterType(currentInterfaceType, implementations.ToList().First());
                        }
                    }
                }
            }
        }
    }
}
