﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Core.ToggleTypes
{
    public class AlwaysOnFeature : IFeature
    {

        public AlwaysOnFeature()
        {
            FeatureName = default(string);
        }

        public string FeatureName
        {
            get;set;
        }

        public IFeature Name(string feature)
        {
            FeatureName = feature;
            return this;
        }

        bool IFeature.Enabled()
        {
            return true;
        }

       


    }
}
