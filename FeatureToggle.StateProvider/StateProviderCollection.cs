using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.StateProvider
{
    public class StateProviderCollection : ProviderCollection
    {
        new public StateProvider this[string name]
        {
            get { return (StateProvider)base[name]; }
        }
    }
}
