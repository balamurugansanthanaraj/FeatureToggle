using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Console
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            var result = default(int);

            if (CrossCutting.FeatureToggleProvider.IsReleaseFeatureEnabled)
            {
                result = (a + b) * 1;
            }
            else 
            {
                result = (a + b) * 2;
            }          

            return result;
        }
        public int Sub(int a, int b)
        {
            var result = default(int);

            if (CrossCutting.FeatureToggleProvider.IsProfileFeatureEnabled("MO"))
            {
                result = (a - b) * 1;
            }
            else
            {
                result = (a - b) * 2;
            }

            return result;
        }
    }
}
