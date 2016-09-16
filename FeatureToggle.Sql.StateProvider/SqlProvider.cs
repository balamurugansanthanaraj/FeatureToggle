using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureToggle.Model;
using FeatureToggle.StateProvider;
using System.Configuration;

namespace FeatureToggle.Sql.StateProvider
{
    public class SqlProvider : FeatureToggle.StateProvider.StateProvider
    {
        List<Feature> features = new List<Feature>
        {
            new Feature
            {
                Name="ReleaseFeature",IsEnabled=true,Type=ToggleType.Releae
            },
            new ProfileFeature
            {
                Name="ProfileFeature",IsEnabled=true,Profile="MO",Type=ToggleType.Profile
            },
              new ProfileFeature
            {
                Name="UserFeature",IsEnabled=true,Profile="Bala",Type=ToggleType.User
            }
        };
        private string _connectionString = default(string);
        public override void Initialize(string name, NameValueCollection config)
        {
            base.Initialize(name, config);
            
            _connectionString = config["connectionString"];
            if (string.IsNullOrEmpty(this._connectionString))
                throw new ConfigurationErrorsException("connectionString must be set to the appropriate value");
        }

        public override IEnumerable<Feature> GetAllFeature()
        {
            return new List<Feature>
            {
                new Feature
                {
                    Name="F1",IsEnabled=true
                }
            };
        }

        public override Feature GetFeature(string featureName)
        {
            return features.SingleOrDefault(a => a.Name == featureName);
        }
    }
}
