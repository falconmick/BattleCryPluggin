using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleCry.Util.Model;

namespace BattleCry.Util
{
    interface IConfigManager
    {
        Config Config { get; }
        bool LoadConfig(string xmlLocation);
        bool SaveConfig(string xmlLocation);
    }
}
