using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hearthstone_Deck_Tracker.Hearthstone;
using BattleCry.Sound;
using BattleCry.Util.Model;
using BattleCry.Util;

namespace BattleCry.Game
{
    class PlayHandler : IPlayHandler
    {
        private readonly ISoundBoard _soundBoard;
        private readonly ICardSoundPicker _cardSoundPicker;

        public PlayHandler(ISoundBoard soundBoard, ICardSoundPicker cardSoundPicker)
        {
            _soundBoard = soundBoard;
            _cardSoundPicker = cardSoundPicker;
        }

        public void OnOpponentPlay(Card card)
        {
            OnPlay(card, CardSource.Opponent);
        }

        public void OnPlayerPlay(Card card)
        {
            OnPlay(card, CardSource.Player);
        }

        private void OnPlay(Card card, CardSource cardSource)
        {
            var soundToPlay = _cardSoundPicker.GetBattleCryFor(card, cardSource);
            if(soundToPlay == null)
            {
                Hearthstone_Deck_Tracker.Logger.WriteLine("BattleCry SFX not found");
                return;
            }

            _soundBoard.Play(soundToPlay);
            Hearthstone_Deck_Tracker.Logger.WriteLine("BattleCry Sound Effect Triggered");
        }

        public void Update()
        {
            _soundBoard.Update();
        }
    }
}
