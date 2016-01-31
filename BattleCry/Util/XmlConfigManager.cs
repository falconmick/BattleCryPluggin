using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleCry.Util.Model;

namespace BattleCry.Util
{
    class XmlConfigManager : IConfigManager
    {
        private Config _config;

        public XmlConfigManager()
        {
            _config = new Config();
        }

        public Config Config
        {
            get
            {
                return _config;
            }
        }

        public bool LoadConfig(string xmlLocation)
        {
            var loaded = true;
            try
            {
                _config = Hearthstone_Deck_Tracker.XmlManager<Config>.Load(xmlLocation);
            }
            catch(System.IO.FileNotFoundException)
            {
                loaded = false;
            }

            return loaded;
        }

        public bool SaveConfig(string xmlLocation)
        {
            Hearthstone_Deck_Tracker.XmlManager<Config>.Save(xmlLocation, _config);
            return true;
        }
    }
}
