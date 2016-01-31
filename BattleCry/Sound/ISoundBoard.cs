using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleCry.Util.Model;
using BattleCry.Util;

namespace BattleCry.Sound
{
    interface ISoundBoard: IUpdateable
    {
        void Play(SoundPlaySetting soundPlaySettings);
    }
}
