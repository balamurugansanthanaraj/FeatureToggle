using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Model
{
    public class ProfileFeature:Feature
    {
        public ProfileFeature()
        {
            Profile = default(string);
        }
        public string Profile { get; set; }
    }
}
