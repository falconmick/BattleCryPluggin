using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleCry.Util.Model;

namespace BattleCry.Sound
{
    interface ICardSoundPicker
    {
        SoundPlaySetting GetBattleCryFor(Hearthstone_Deck_Tracker.Hearthstone.Card card, CardSource cardSource);
    }
}
