using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class ProfileToggle : IToggle
    {
        public bool IsOn()
        {
            if (_featureName == default(string)) throw new ArgumentException("Feature name is not specified");
            if (_profileName == default(string)) throw new ArgumentException("Profile name is not specified");

            var toggleService = new FeatureToggle.Services.ToggleService();
            var feature = toggleService.GetFeature(_featureName);


            if (feature != null && feature is FeatureToggle.Model.ProfileFeature)
            {
                var profileFeatureModel = ((FeatureToggle.Model.ProfileFeature)feature);
                return profileFeatureModel.IsEnabled && profileFeatureModel.Profile == _profileName;
            }
            else return false;
        }
        public ProfileToggle(string featureName, string profileName)
        {
            _featureName = featureName;
            _profileName = profileName;
        }

        private string _featureName = default(string);
        private string _profileName = default(string);

       
    }
}
