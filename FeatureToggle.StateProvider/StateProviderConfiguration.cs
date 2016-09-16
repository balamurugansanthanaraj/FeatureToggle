using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.StateProvider
{
    public class StateProviderConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("providers")]
        public ProviderSettingsCollection Providers
        {
            get { return (ProviderSettingsCollection)base["providers"]; }
        }
        [ConfigurationProperty("default", DefaultValue = "SqlProvider")]
        public string Default
        {
            get { return (string)base["default"]; }
            set
            {
                base["default"] = value;
            }
        }

    }
}
