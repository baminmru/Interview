using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Area
    {
        public int h { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Detection
    {
        public Area area { get; set; }
        public double confidence { get; set; }
    }

    public class Body
    {
        public List<Detection> detections { get; set; }
    }

    public class IResult
    {
        public bool success { get; set; }
        public Body body { get; set; }
    }
}
