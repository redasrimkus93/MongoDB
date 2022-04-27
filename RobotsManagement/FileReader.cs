using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsManagement
{
    internal class FileReader
    {
        public Robot ConvertJsonToRobot(string path)
        {
            var text = File.ReadAllText(path);

            var robot = JsonConvert.DeserializeObject<Robot>(text);

            return robot;
        }
    }
}
