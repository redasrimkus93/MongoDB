using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsManagement
{
    internal class Robot
    {
        public int Id { get; set; }
        public List<Arm> Arms { get; set; } = new List<Arm>();
        public List<Leg> Legs { get; set; } = new List<Leg>();
        public Torso Torso { get; set; }
        public Head Head { get; set; }

    }
}
