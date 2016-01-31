using BattleCry.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry.Game
{
    interface IGameMonitor: IUpdateable
    {
        void Initialize();
    }
}
