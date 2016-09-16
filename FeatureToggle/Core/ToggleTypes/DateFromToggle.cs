using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class DateFromToggle : IToggle
    {
        public bool IsOn()
        {
            if (_featureName == default(string)) throw new ArgumentException("Feature name is not specified");
            var toggleService = new FeatureToggle.Services.ToggleService();
            var feature = toggleService.GetFeature(_featureName);

            if (feature != null && feature is FeatureToggle.Model.DateFromFeature)
            {
                var profileFeatureModel = ((FeatureToggle.Model.DateFromFeature)feature);
                return profileFeatureModel.IsEnabled && profileFeatureModel.DateFrom  <= DateTime.Today;
            }
            else return false;
        }
        private string _featureName = default(string);

        public DateFromToggle(string featureName)
        {
            _featureName = featureName;
        }
    }
}
