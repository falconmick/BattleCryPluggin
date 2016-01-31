using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleCry.Util.Model;

namespace BattleCry.Sound
{
    interface ISoundBoard
    {
        void Play(SoundPlaySetting soundPlaySettings);
    }
}
