using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Model
{
    public class DateFromFeature:Feature
    {
        public DateFromFeature()
        {
            DateFrom = default(DateTime);
        }
        public DateTime DateFrom { get; set; }
    }
}
