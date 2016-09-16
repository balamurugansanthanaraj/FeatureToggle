using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Model
{
    public class UserFeature:Feature
    {
        public UserFeature()
        {
            UserName = default(string);
        }
        public string UserName { get; set; }
    }
}
