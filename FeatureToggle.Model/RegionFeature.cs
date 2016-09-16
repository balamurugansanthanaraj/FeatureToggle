using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Model
{
    public class RegionFeature:Feature
    {
        public RegionFeature()
        {
            Region = default(string);
        }
        public string Region { get; set; }
    }
}
