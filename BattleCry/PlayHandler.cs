using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hearthstone_Deck_Tracker.Hearthstone;

namespace BattleCry
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
            OnPlay(card);
        }

        public void OnPlayerPlay(Card card)
        {
            OnPlay(card);
        }

        private void OnPlay(Card card)
        {
            var soundToPlay = _cardSoundPicker.GetBattleCryFor(card);
            if(soundToPlay == null)
            {
                Hearthstone_Deck_Tracker.Logger.WriteLine("BattleCry SFX not found");
                return;
            }

            _soundBoard.Play(soundToPlay);
            Hearthstone_Deck_Tracker.Logger.WriteLine("BattleCry Sound Effect Triggered");
        }
    }
}
