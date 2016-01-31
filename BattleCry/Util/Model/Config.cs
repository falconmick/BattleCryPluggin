using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry.Util.Model
{
    public class Config
    {
        public Config()
        {
            SoundFiles = new List<SoundPlaySetting>();
        }

        public List<SoundPlaySetting> SoundFiles { get; set; }
    }
}
