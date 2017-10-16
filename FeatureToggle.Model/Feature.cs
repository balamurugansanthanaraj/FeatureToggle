using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Model
{
    public class Feature
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public virtual bool IsEnabled { get; set; }
        public ToggleType Type { get; set; }
    }
  
  
    
}
