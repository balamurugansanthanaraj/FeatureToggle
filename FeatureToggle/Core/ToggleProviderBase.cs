using FeatureToggle.Core.ToggleTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureToggle.Model;

namespace FeatureToggle.Core
{
    public class ToggleProviderBase
    {
        public static bool IsEnabled(string featureName, ToggleType toggleType)
        {
            var toggle = default(IToggle);
            switch (toggleType)
            {                
                case ToggleType.Releae:
                    toggle = new ReleaseToggle(featureName);
                    break;
            }           
            return toggle.IsOn();
        }
        public static bool IsEnabled(string featureName,string profileOrUserOrRegionName, ToggleType toggleType)
        {
            var toggle = default(IToggle);
            switch (toggleType)
            {
                case ToggleType.Profile:
                    toggle = new ToggleTypes.ProfileToggle(featureName, profileOrUserOrRegionName);
                    break;
                case ToggleType.User:
                    toggle = new ToggleTypes.UserToggle(featureName, profileOrUserOrRegionName);
                    break;
                case ToggleType.Region:
                    toggle = new ToggleTypes.RegionToggle(featureName, profileOrUserOrRegionName);
                    break;
            }
            return toggle.IsOn();
        }

        //public IToggle CreateInstance(Feature feature)
        //{
        //    var toggle = default(IToggle);
        //    switch (feature.Type)
        //    {
        //        case ToggleType.Releae:
        //            toggle = new ReleaseToggle(feature.Name);
        //            break;
        //        case ToggleType.Profile:
        //            toggle = new ToggleTypes.ProfileToggle(feature.Name, ((ProfileFeature)feature).Profile);
        //            break;
        //        case ToggleType.User:
        //            toggle = new ToggleTypes.UserToggle(feature.Name, ((UserFeature)feature).UserName);
        //            break;
        //        case ToggleType.Region:
        //            toggle = new ToggleTypes.RegionToggle(feature.Name, ((RegionFeature)feature).Region);
        //            break;
        //    }

        //    return toggle;
        //}
      
    }
}
