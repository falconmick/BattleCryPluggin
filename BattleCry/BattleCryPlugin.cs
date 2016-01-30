using Hearthstone_Deck_Tracker.Plugins;
using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry
{
    public class BattleCryPlugin : IPlugin
    {
        private readonly IGameMonitor _gameMonitor;

        public BattleCryPlugin()
        {
            var soundBoard = new SoundBoard("Plugins\\AudioFiles\\");
            var cardSoundPicker = new HardCodedCardSoundPicker();
            var playHandler = new PlayHandler(soundBoard, cardSoundPicker);
            _gameMonitor = new GameMonitor(playHandler);
        }

        public string Author
        {
            get
            {
                return "Michael Crook";
            }
        }

        public string ButtonText
        {
            get
            {
                return "Battle Cry";
            }
        }

        public string Description
        {
            get
            {
                return "For when the original Battle Cries arn't enough";
            }
        }

        public MenuItem MenuItem
        {
            get
            {
                return null;
            }
        }

        public string Name
        {
            get
            {
                return "Battle Cry";
            }
        }

        public Version Version
        {
            get
            {
                return new Version(0, 0, 1);
            }
        }

        public void OnButtonPress()
        {
        }

        public void OnLoad()
        {
            _gameMonitor.Initialize();
        }

        public void OnUnload()
        {

        }

        public void OnUpdate()
        {
        }
    }
}
