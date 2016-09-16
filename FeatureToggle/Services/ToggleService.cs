using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureToggle.Model;
using FeatureToggle.StateProvider;

namespace FeatureToggle.Services
{
    public class ToggleService
    {
        public IEnumerable<Feature> GetAllFeature()
        {
            return StateProviderManager.Provider.GetAllFeature();            
        }
        public Feature GetFeature(string featureName)
        {
            return StateProviderManager.Provider.GetFeature(featureName);
        }
    }
}
