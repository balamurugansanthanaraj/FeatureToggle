using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace FeatureToggle.StateProvider
{
    public class StateProviderManager
    {        
        private static StateProvider _defaultProvider;
        private static StateProviderCollection _providers;
        static StateProviderManager()
        {
            Initialize();
        }

        private static void Initialize()
        {
            var configuration = (StateProviderConfiguration)ConfigurationManager.GetSection("FeatureToggleStateProvider");
            if (configuration == null)
                throw new ConfigurationErrorsException("FeatureToggleStateProvider configuration section is not set correctly.");
            _providers = new StateProviderCollection();
            ProvidersHelper.InstantiateProviders(configuration.Providers, _providers, typeof(StateProvider));
            _providers.SetReadOnly();
            _defaultProvider = _providers[configuration.Default];
            if (_defaultProvider == null)
                throw new Exception("defaultProvider");
        }

        public static StateProvider Provider { get { return _defaultProvider; } }
        public static StateProviderCollection Providers { get { return _providers; } }
    }
}
