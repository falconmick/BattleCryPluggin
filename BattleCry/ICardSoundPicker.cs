using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry
{
    interface ICardSoundPicker
    {
        SoundPlaySetting GetBattleCryFor(Hearthstone_Deck_Tracker.Hearthstone.Card card);
    }
}
