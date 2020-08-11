using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabi_Tools.Class_Definitions
{
    /// <summary>
    /// This class will be responsible for holding values related to user settings, as well as saving and loading them
    /// </summary>
    static class MabiSettings
    {
        public static class Commerce
        {
            public static String cityFilePath { get; } = "Resources/Cities.csv";
            public static String transportFilePath { get; } = "Resources/Transport.csv";
            public static String timeFilePath { get; } = "Resources/Time.csv";
        }   
    }
}
