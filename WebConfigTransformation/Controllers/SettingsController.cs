using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;

namespace WebConfigTransformation.Controllers
{
    public class SettingsController : ApiController
    {
        //http://localhost:10346/api/Settings
        // Run in Debug mode to see the debug configuration
        // Publish and Run or check the web config to see the keys difference(F:\Linoy\WORKS\Publish) 

        public IDictionary<string, string> Get()
        {
            IDictionary<string, string> keyValues = new Dictionary<string, string>();

            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                keyValues.Add(key, ConfigurationManager.AppSettings[key]);
            }

            return keyValues;
        }
    }
}
