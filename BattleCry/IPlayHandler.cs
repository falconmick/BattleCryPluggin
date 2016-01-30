using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry
{
    interface IPlayHandler
    {
        void OnPlayerPlay(Hearthstone_Deck_Tracker.Hearthstone.Card card);
        void OnOpponentPlay(Hearthstone_Deck_Tracker.Hearthstone.Card card);
    }
}
