using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureToggle.Model
{
    public enum ToggleType
    {
        AlwaysOn,
        AlwaysOff,
        DateFrom,
        TillDate,
        DateRange,
        User,
        Profile,
        Region,
        Releae,
    }
}
