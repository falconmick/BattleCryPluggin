using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleCry.Util;
using BattleCry.Util.Model;
using Hearthstone_Deck_Tracker.Hearthstone;

namespace BattleCry.Sound
{
    class ConfigCardSoundPicker : ICardSoundPicker
    {
        private readonly string configFileLoc;
        private readonly IConfigManager _configManager;

        public ConfigCardSoundPicker(IConfigManager configManager, string configFileLoc)
        {
            _configManager = configManager;
            this.configFileLoc = configFileLoc;
            Init();
        }

        public void Init()
        {
            // if we get false back, create one :)
            if(!_configManager.LoadConfig(configFileLoc))
            {
                _configManager.Config.SoundFiles.Add(
                    new SoundPlaySetting
                    {
                        CardId = "AT_079",
                        CardSource = CardSource.All,
                        Delay = 700,
                        FileName = "johncena.mp3"
                    });

                _configManager.SaveConfig(configFileLoc);
            }
        }


        // todo make choose random not just first;
        public SoundPlaySetting GetBattleCryFor(Card card, CardSource cardSource)
        {
            var soundPlaySetting = _configManager.Config.SoundFiles.FirstOrDefault((sound) =>
            {
                return (sound.CardSource == CardSource.All || cardSource == sound.CardSource) && sound.CardId == card.Id;
            });

            return soundPlaySetting;
        }
    }
}
