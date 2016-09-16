using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class RegionToggle : IToggle
    {
        public bool IsOn()
        {
            if (_featureName == default(string)) throw new ArgumentException("Feature name is not specified");
            if (_region == default(string)) throw new ArgumentException("Region name is not specified");

            var toggleService = new FeatureToggle.Services.ToggleService();
            var feature = toggleService.GetFeature(_featureName);


            if (feature != null && feature is FeatureToggle.Model.RegionFeature)
            {
                var profileFeatureModel = ((FeatureToggle.Model.RegionFeature)feature);
                return profileFeatureModel.IsEnabled && profileFeatureModel.Region == _region;
            }
            else return false;
        }
        public RegionToggle(string featureName, string region)
        {
            _featureName = featureName;
            _region = region;
        }

        private string _featureName = default(string);
        private string _region = default(string);
    }
}
