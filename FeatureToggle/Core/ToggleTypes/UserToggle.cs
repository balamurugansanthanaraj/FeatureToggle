using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class UserToggle : IToggle
    {
        public bool IsOn()
        {
            if (_featureName == default(string)) throw new ArgumentException("Feature name is not specified");
            if (_userName == default(string)) throw new ArgumentException("UserName name is not specified");

            var toggleService = new FeatureToggle.Services.ToggleService();
            var feature = toggleService.GetFeature(_featureName);


            if (feature != null && feature is FeatureToggle.Model.UserFeature)
            {
                var profileFeatureModel = ((FeatureToggle.Model.UserFeature)feature);
                return profileFeatureModel.IsEnabled && profileFeatureModel.UserName == _userName;
            }
            else return false;
        }
        public UserToggle(string featureName, string userName)
        {
            _featureName = featureName;
            _userName = userName;
        }

        private string _featureName = default(string);
        private string _userName = default(string);

    }
}
