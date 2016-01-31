using BattleCry.Util.Model;
using System;

namespace BattleCry.Sound.Model
{
    class PlayQueueItem
    {
        public SoundPlaySetting SoundPlaySetting { get; set; }
        public long StartPlayingAfter { get; set; }
    }
}
