using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry
{
    class GameMonitor : IGameMonitor
    {
        private readonly IPlayHandler _playHandler;

        public GameMonitor(IPlayHandler playHandler)
        {
            _playHandler = playHandler;
        }

        public void Initialize()
        {
            Hearthstone_Deck_Tracker.API.GameEvents.OnOpponentPlay.Add(_playHandler.OnOpponentPlay);
            Hearthstone_Deck_Tracker.API.GameEvents.OnPlayerPlay.Add(_playHandler.OnPlayerPlay);
            Hearthstone_Deck_Tracker.Logger.WriteLine("Setup BattleCry Event Handlers");
        }
    }
}
