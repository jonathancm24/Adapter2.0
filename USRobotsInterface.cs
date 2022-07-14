using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2._0
{
    interface USRobotsInterface
    {
        float CurrentSpeedInMilesPerHour { get; set; }
        void EnablePartialFirstLawMode();
        void Jump(float feet);
    }
}
