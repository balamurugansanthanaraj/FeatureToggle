using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureToggle;
namespace CrossCutting
{
    public class FeatureToggleProvider:FeatureToggle.Core.ToggleProviderBase
    {
        public static bool IsReleaseFeatureEnabled
        {
            get
            {
                return IsEnabled("ReleaseFeature", FeatureToggle.Model.ToggleType.Releae);
            }
        }
        public static bool IsProfileFeatureEnabled(string profileName)
        {
            return IsEnabled("ProfileFeature", profileName, FeatureToggle.Model.ToggleType.Profile);
        }
    }
}
