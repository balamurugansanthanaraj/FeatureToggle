using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class ReleaseFeature : IFeature
    {
        public ReleaseFeature()
        {
            FeatureName = default(string);
        }

        public string FeatureName
        {
            get; set;
        }

        public IFeature Name(string feature)
        {
            FeatureName = feature;
            return this;
        }

        bool IFeature.Enabled()
        {
            if (FeatureName == default(string)) throw new ArgumentException("Feature name is not specified");
            // service layer call goes here
            return false;
        }
    }
}
