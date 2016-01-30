using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hearthstone_Deck_Tracker.Hearthstone;

namespace BattleCry
{
    class HardCodedCardSoundPicker : ICardSoundPicker
    {
        private readonly Dictionary<string, SoundPlaySetting> soundDictionary;

        public HardCodedCardSoundPicker()
        {
            soundDictionary = new Dictionary<string, SoundPlaySetting>
            {
                { "AT_079", new SoundPlaySetting
                    {
                        Delay = 1000,
                        FileName = "johncena.mp3"
                    }
                }
            };
        }

        public SoundPlaySetting GetBattleCryFor(Card card)
        {
            return soundDictionary.ContainsKey(card.Id) ? soundDictionary[card.Id] : null;
        }
    }
}
