using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core
{
    public interface IFeature
    {
        //bool Enabled { get; set; }
        IFeature Name(string feature);
        bool Enabled();
        string FeatureName { get; set; }
    }

    public interface IProfileFeature:IFeature
    {
        IProfileFeature ForThisProfile(string profile);
    }
   
}
