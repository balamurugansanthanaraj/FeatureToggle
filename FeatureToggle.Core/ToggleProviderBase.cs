using FeatureToggle.Core.ToggleTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FeatureToggle.Core.Enum;

namespace FeatureToggle.Core
{
    public class ToggleProviderBase
    {
        public bool IsEnabled(string featureName,ToggleType toggleType)
        {            
            IFeature feature = default(IFeature);
            switch (toggleType)
            {
                case ToggleType.AlwaysOnFeature:
                    feature = new AlwaysOnFeature();
                    break;
                case ToggleType.AlwaysOffFeature:
                    feature = new AlwaysOffFeature();
                    break;
            }
            return feature.Name(featureName).Enabled();
        }
    }
}
