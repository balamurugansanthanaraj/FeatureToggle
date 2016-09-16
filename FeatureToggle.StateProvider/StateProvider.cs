using FeatureToggle.Model;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.StateProvider
{
    public abstract class StateProvider:ProviderBase
    {
        public abstract IEnumerable<Feature> GetAllFeature();
        public abstract Feature GetFeature(string featureName);
    }
}
