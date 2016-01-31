using BattleCry.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry.Game
{
    interface IPlayHandler: IUpdateable
    {
        void OnPlayerPlay(Hearthstone_Deck_Tracker.Hearthstone.Card card);
        void OnOpponentPlay(Hearthstone_Deck_Tracker.Hearthstone.Card card);
    }
}
