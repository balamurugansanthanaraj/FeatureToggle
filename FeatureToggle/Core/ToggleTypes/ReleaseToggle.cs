using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class ReleaseToggle : IToggle
    {
        public bool IsOn()
        {
            if (_featureName == default(string)) throw new ArgumentException("Feature name is not specified");
            var toggleService = new FeatureToggle.Services.ToggleService();
            var feature = toggleService.GetFeature(_featureName);

            return feature == default(Model.Feature) ? false : feature.IsEnabled;
        }
        private string _featureName = default(string);

        public ReleaseToggle(string featureName)
        {
            _featureName = featureName;
        }

      
    }
}
