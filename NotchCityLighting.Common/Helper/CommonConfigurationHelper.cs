using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotchCityLighting.Common.Helper
{
    public class CommonConfiguration
    {
        public static CommonConfigurationHelper Configuration;

        static CommonConfiguration()
        {
            Configuration = new CommonConfigurationHelper();
        }
    }

    public class CommonConfigurationHelper
    {
        private const string _environment = "Environment_Name";
        public string Environment_Name
        {
            get
            {
                string result = System.Configuration.ConfigurationManager.AppSettings[_environment];
                if (!String.IsNullOrWhiteSpace(result))
                {
                    result = result.ToUpper();
                }
                return result;
            }
        }

        private const long _timeout = 60L * 60L * 10000000L; //Format: (# Minutes)*(Seconds Multiplier)*(10 000 000). Length of time in ticks (1 hour) reference: 1 tick = 100 nano seconds 
        public TimeSpan TransactionScope_Timeout
        {
            get
            {
                TimeSpan result = new TimeSpan(_timeout);
                return result;
            }
        }
    }
}
