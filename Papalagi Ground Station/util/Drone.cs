using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papalagi_Ground_Station.util
{
    class Drone
    {
        public string droneId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public bool tracking{ get; set; }
        public string trackingId { get; set; }

    }
}
