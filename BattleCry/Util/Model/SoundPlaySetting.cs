using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleCry.Util.Model
{
    public class SoundPlaySetting
    {
        public string FileName { get; set; }
        public string CardId { get; set; }
        public int Delay { get; set; }
        public CardSource CardSource { get; set; }
    }
}
